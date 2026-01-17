namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDonorAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonorPassport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDoneeAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDoneePassport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDoneeName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFlatRegData = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFlatArea = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFlatAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(16, 652);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(613, 62);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "СФОРМИРОВАТЬ ДОГОВОР (.DOCX)";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(613, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общие сведения";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(320, 43);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(265, 22);
            this.txtDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(13, 43);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(265, 22);
            this.txtCity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Город";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDonorAddress);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDonorPassport);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDonorName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(16, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(613, 172);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Даритель (Кто дарит)";
            // 
            // txtDonorAddress
            // 
            this.txtDonorAddress.Location = new System.Drawing.Point(13, 135);
            this.txtDonorAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonorAddress.Name = "txtDonorAddress";
            this.txtDonorAddress.Size = new System.Drawing.Size(572, 22);
            this.txtDonorAddress.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Адрес регистрации";
            // 
            // txtDonorPassport
            // 
            this.txtDonorPassport.Location = new System.Drawing.Point(13, 87);
            this.txtDonorPassport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonorPassport.Name = "txtDonorPassport";
            this.txtDonorPassport.Size = new System.Drawing.Size(572, 22);
            this.txtDonorPassport.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Паспортные данные (все)";
            // 
            // txtDonorName
            // 
            this.txtDonorName.Location = new System.Drawing.Point(13, 39);
            this.txtDonorName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonorName.Name = "txtDonorName";
            this.txtDonorName.Size = new System.Drawing.Size(572, 22);
            this.txtDonorName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ФИО полностью";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDoneeAddress);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtDoneePassport);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDoneeName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(16, 288);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(613, 172);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Одаряемый (Кто получает)";
            // 
            // txtDoneeAddress
            // 
            this.txtDoneeAddress.Location = new System.Drawing.Point(13, 135);
            this.txtDoneeAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoneeAddress.Name = "txtDoneeAddress";
            this.txtDoneeAddress.Size = new System.Drawing.Size(572, 22);
            this.txtDoneeAddress.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Адрес регистрации";
            // 
            // txtDoneePassport
            // 
            this.txtDoneePassport.Location = new System.Drawing.Point(13, 87);
            this.txtDoneePassport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoneePassport.Name = "txtDoneePassport";
            this.txtDoneePassport.Size = new System.Drawing.Size(572, 22);
            this.txtDoneePassport.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Паспортные данные (все)";
            // 
            // txtDoneeName
            // 
            this.txtDoneeName.Location = new System.Drawing.Point(13, 39);
            this.txtDoneeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoneeName.Name = "txtDoneeName";
            this.txtDoneeName.Size = new System.Drawing.Size(572, 22);
            this.txtDoneeName.TabIndex = 1;
            this.txtDoneeName.TextChanged += new System.EventHandler(this.txtDoneeName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "ФИО полностью";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFlatRegData);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtFlatArea);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtFlatAddress);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(16, 468);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(613, 172);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Объект (Квартира)";
            // 
            // txtFlatRegData
            // 
            this.txtFlatRegData.Location = new System.Drawing.Point(13, 135);
            this.txtFlatRegData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlatRegData.Name = "txtFlatRegData";
            this.txtFlatRegData.Size = new System.Drawing.Size(572, 22);
            this.txtFlatRegData.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Документы собственности";
            // 
            // txtFlatArea
            // 
            this.txtFlatArea.Location = new System.Drawing.Point(13, 87);
            this.txtFlatArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlatArea.Name = "txtFlatArea";
            this.txtFlatArea.Size = new System.Drawing.Size(572, 22);
            this.txtFlatArea.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 68);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Площадь (общая и жилая)";
            // 
            // txtFlatAddress
            // 
            this.txtFlatAddress.Location = new System.Drawing.Point(13, 39);
            this.txtFlatAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlatAddress.Name = "txtFlatAddress";
            this.txtFlatAddress.Size = new System.Drawing.Size(572, 22);
            this.txtFlatAddress.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Адрес квартиры";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 727);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор договора дарения";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDonorAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonorPassport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDoneeAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDoneePassport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDoneeName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtFlatRegData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFlatArea;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFlatAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}