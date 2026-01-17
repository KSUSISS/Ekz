using System;
using System.IO;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            QuestPDF.Settings.License = LicenseType.Community;
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
            // 1. Настраиваем окно сохранения файла (для PDF)
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Документ PDF|*.pdf";
            sfd.FileName = "Договор_Дарения_" + txtDoneeName.Text + ".pdf";
            sfd.Title = "Выберите место для сохранения договора";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string outputPath = sfd.FileName;

                // Используем имеющиеся поля и заглушки для отсутствующих
                string totalAreaNum = txtFlatArea.Text;
                string totalAreaWords = NumberToWords(totalAreaNum);

                string valuationNum = "0";
                string valuationWords = NumberToWords(valuationNum);

                try
                {
                    // 2. Создаем и генерируем PDF-документ
                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(30);
                            page.DefaultTextStyle(x => x.FontSize(11).FontFamily(Fonts.Arial));

                            page.Content()
                                .Column(column =>
                                {
                                    column.Spacing(10);

                                    column.Item().Text("Договор дарения квартиры").Bold().FontSize(14).AlignLeft();
                                    column.Item().Text($"г. {txtCity.Text}").AlignLeft();
                                    column.Item().Text($"«{txtDate.Text}»").AlignRight();

                                    // --- 1. ПРЕДМЕТ ДОГОВОРА ---
                                    column.Item().Text("1. Предмет договора").Bold().FontSize(12);

                                    string donorDetails = $"{txtDonorName.Text}, паспорт серии [XX], N [000000], выдан [Орган выдачи], зарегистрированный(ая) по адресу: {txtDonorAddress.Text}, именуемый в дальнейшем \"Даритель\"";
                                    string doneeDetails = $"{txtDoneeName.Text}, паспорт серии [XX], N [000000], выдан [Орган выдачи], зарегистрированный(ая) по адресу: {txtDoneeAddress.Text}, именуемый в дальнейшем \"Одаряемый\"";

                                    column.Item().Text(text =>
                                    {
                                        text.Span(donorDetails).FontSize(11);
                                        text.Span(" и ").FontSize(11);
                                        text.Span(doneeDetails).FontSize(11);
                                        text.Span(", заключили настоящий договор о нижеследующем:").FontSize(11);
                                    });

                                    column.Item().Text(text =>
                                    {
                                        text.Line($"1.1. По настоящему договору Даритель безвозмездно передает Одаряемому в собственность квартиру, находящуюся по адресу: {txtFlatAddress.Text} (далее - Квартира), а Одаряемый принимает ее в качестве дара.");
                                        text.Line($"1.3. Квартира расположена на [Этаж] этаже [Кол-во этажей] этажного дома [Год постройки] года постройки, состоит из [Кол-во комнат] комнат, общей площадью {totalAreaNum} ({totalAreaWords}) кв. м, жилой площадью [Жилая площадь] кв. м.");
                                        text.Line($"1.4. Инвентаризационная оценка Квартиры составляет {valuationNum} ({valuationWords}) рублей.");
                                    });

                                    // --- 7. Реквизиты и подписи сторон ---
                                    column.Item().PaddingTop(20).Text("7. Реквизиты и подписи сторон").Bold().FontSize(12);

                                    column.Item().Row(row =>
                                    {
                                        row.RelativeItem().Column(col =>
                                        {
                                            col.Item().Text("Даритель").Bold();
                                            col.Item().Text($"[ФИО: {txtDonorName.Text}]");
                                            col.Item().Text("[подпись, инициалы, фамилия]");
                                        });

                                        row.RelativeItem().Column(col =>
                                        {
                                            col.Item().Text("Одаряемый").Bold();
                                            col.Item().Text($"[ФИО: {txtDoneeName.Text}]");
                                            col.Item().Text("[подпись, инициалы, фамилия]");
                                        });
                                    });

                                    // Добавь остальные пункты договора по аналогии
                                });
                        });
                    }).GeneratePdf(outputPath); // Генерируем и сохраняем

                    MessageBox.Show("Договор успешно создан и сохранен в PDF!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Предлагаем сразу открыть файл
                    System.Diagnostics.Process.Start(outputPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при генерации PDF: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }

        private void txtDoneeName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
