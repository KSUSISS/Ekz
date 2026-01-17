using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string NumberToWords(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                return "[НУЖНА ЦИФРА]";
            }
            // Простая заглушка:
            return string.Format("[{0} ПРОПИСЬЮ - НЕОБХОДИМА РЕАЛИЗАЦИЯ]", number);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // 1. Указываем путь к шаблону (он должен лежать в папке с .exe файлом)
            string templatePath = Path.Combine(Application.StartupPath, "template.docx");

            // Проверяем, есть ли шаблон на месте
            if (!File.Exists(templatePath))
            {
                MessageBox.Show("Ошибка: Файл template.docx не найден в папке с программой!\nПоложи его в: " + Application.StartupPath);
                return;
            }

            // 2. Настраиваем окно сохранения файла
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Документ Word|*.docx";
            sfd.FileName = "Договор_Дарения_" + txtDoneeName.Text + ".docx";
            sfd.Title = "Выберите место для сохранения договора";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string outputPath = sfd.FileName;

                // Используем имеющиеся поля и заглушки для отсутствующих
                string totalAreaNum = txtFlatArea.Text;
                string totalAreaWords = NumberToWords(totalAreaNum);

                // Заглушки для инвентаризационной оценки, т.к. поля нет
                string valuationNum = "0";
                string valuationWords = NumberToWords(valuationNum);

                try
                {
                    // 3. Работаем с документом
                    using (DocX document = DocX.Load(templatePath))
                    {
                        // ----- Базовые замены (как у тебя) -----
                        document.ReplaceText("{CITY}", txtCity.Text);
                        document.ReplaceText("{DATE}", txtDate.Text);

                        // ----- Даритель (Используем имеющиеся поля и заглушки) -----
                        document.ReplaceText("{DONOR_NAME}", txtDonorName.Text);
                        document.ReplaceText("{DONOR_PASSPORT}", txtDonorPassport.Text);
                        document.ReplaceText("{DONOR_ADDRESS}", txtDonorAddress.Text);

                        // Заглушки для недостающих деталей паспорта Дарителя
                        document.ReplaceText("{DONOR_PASSPORT_SERIES}", "XX");
                        document.ReplaceText("{DONOR_PASSPORT_NUMBER}", "000000");
                        document.ReplaceText("{DONOR_PASSPORT_ISSUER}", "[Орган выдачи Дарителя]");
                        document.ReplaceText("{DONOR_PASSPORT_ISSUE_DATE}", "[Дата выдачи Дарителя]");
                        document.ReplaceText("{DONOR_PASSPORT_CODE}", "[Код Дарителя]");

                        // ----- Одаряемый (Используем имеющиеся поля и заглушки) -----
                        document.ReplaceText("{DONEE_NAME}", txtDoneeName.Text);
                        document.ReplaceText("{DONEE_PASSPORT}", txtDoneePassport.Text);
                        document.ReplaceText("{DONEE_ADDRESS}", txtDoneeAddress.Text);

                        // Заглушки для недостающих деталей паспорта Одаряемого
                        document.ReplaceText("{DONEE_PASSPORT_SERIES}", "XX");
                        document.ReplaceText("{DONEE_PASSPORT_NUMBER}", "000000");
                        document.ReplaceText("{DONEE_PASSPORT_ISSUER}", "[Орган выдачи Одаряемого]");
                        document.ReplaceText("{DONEE_PASSPORT_ISSUE_DATE}", "[Дата выдачи Одаряемого]");
                        document.ReplaceText("{DONEE_PASSPORT_CODE}", "[Код Одаряемого]");

                        // ----- Детали Квартиры -----
                        document.ReplaceText("{FLAT_ADDRESS}", txtFlatAddress.Text);
                        document.ReplaceText("{FLAT_DOCS}", txtFlatRegData.Text);

                        // Заглушки для этажа, комнат и жилой площади
                        document.ReplaceText("{FLAT_FLOOR}", "[Этаж]");
                        document.ReplaceText("{FLAT_ROOMS}", "[Кол-во комнат]");
                        document.ReplaceText("{FLAT_LIVE_AREA_NUM}", "0");
                        document.ReplaceText("{FLAT_LIVE_AREA_PROPIS}", "[НОЛЬ ПРОПИСЬЮ]");

                        // Замена общей площади цифрами и прописью
                        document.ReplaceText("{FLAT_AREA_NUM}", totalAreaNum); // Общая площадь цифрами
                        document.ReplaceText("{FLAT_AREA_PROPIS}", totalAreaWords); // Общая площадь прописью

                        // Замена оценки цифрами и прописью (используем заглушки)
                        document.ReplaceText("{FLAT_VALUATION_NUM}", valuationNum);
                        document.ReplaceText("{FLAT_VALUATION_PROPIS}", valuationWords);

                        // Заглушки для остальных полей договора
                        document.ReplaceText("{BUILD_YEAR}", "[Год постройки]"); // Год постройки
                        document.ReplaceText("{BTI_CITY}", "[Город/Область БТИ]"); // Справка БТИ
                        document.ReplaceText("{BTI_DATE}", "[Дата справки БТИ]");
                        document.ReplaceText("{BTI_NUMBER}", "[Номер справки БТИ]");
                        document.ReplaceText("{FREE_DOC_NAME}", "[Название справки о свободе]"); // Справка о свободе
                        document.ReplaceText("{FREE_DOC_DATE}", "[Дата справки о свободе]");
                        document.ReplaceText("{FREE_DOC_NUMBER}", "[Номер справки о свободе]");
                        document.ReplaceText("{REG_ORG_NAME}", "[Наименование органа регистрации]"); // Орган регистрации
                        document.ReplaceText("{REG_EXPENSES}", "[Даритель/Одаряемый]"); // Расходы на регистрацию
                        document.ReplaceText("{TRANSFER_TERM}", "[Срок передачи]"); // Срок передачи
                        document.ReplaceText("{REG_ORG_END}", "[Наименование органа регистрации прав]"); // Конец договора

                        // Сохраняем по выбранному пользователем пути
                        document.SaveAs(outputPath);
                    }

                    MessageBox.Show("Договор успешно создан и сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Предлагаем сразу открыть файл
                    System.Diagnostics.Process.Start(outputPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }

        private void txtDoneeName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
