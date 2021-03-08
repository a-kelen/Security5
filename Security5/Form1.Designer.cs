namespace Security5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.encrypt = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.outText = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.import = new System.Windows.Forms.Button();
            this.decryptedText = new System.Windows.Forms.RichTextBox();
            this.encryptedText = new System.Windows.Forms.RichTextBox();
            this.decrypt = new System.Windows.Forms.Button();
            this.openEncrypted = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(6, 9);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Відкрити";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(6, 38);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 23);
            this.saveFile.TabIndex = 1;
            this.saveFile.Text = "Зберегти";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(6, 68);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(75, 23);
            this.encrypt.TabIndex = 2;
            this.encrypt.Text = "Шифрувати";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(6, 98);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(360, 241);
            this.textBox.TabIndex = 3;
            this.textBox.Text = "";
            // 
            // outText
            // 
            this.outText.Location = new System.Drawing.Point(376, 98);
            this.outText.Name = "outText";
            this.outText.ReadOnly = true;
            this.outText.Size = new System.Drawing.Size(360, 241);
            this.outText.TabIndex = 4;
            this.outText.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 381);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.openFile);
            this.tabPage1.Controls.Add(this.outText);
            this.tabPage1.Controls.Add(this.saveFile);
            this.tabPage1.Controls.Add(this.textBox);
            this.tabPage1.Controls.Add(this.encrypt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифрування";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.import);
            this.tabPage2.Controls.Add(this.decryptedText);
            this.tabPage2.Controls.Add(this.encryptedText);
            this.tabPage2.Controls.Add(this.decrypt);
            this.tabPage2.Controls.Add(this.openEncrypted);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Розшифрування";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(7, 35);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(98, 23);
            this.import.TabIndex = 4;
            this.import.Text = "Імпортувати";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // decryptedText
            // 
            this.decryptedText.ForeColor = System.Drawing.SystemColors.Window;
            this.decryptedText.Location = new System.Drawing.Point(370, 93);
            this.decryptedText.Name = "decryptedText";
            this.decryptedText.ReadOnly = true;
            this.decryptedText.Size = new System.Drawing.Size(367, 251);
            this.decryptedText.TabIndex = 3;
            this.decryptedText.Text = "";
            // 
            // encryptedText
            // 
            this.encryptedText.Location = new System.Drawing.Point(4, 93);
            this.encryptedText.Name = "encryptedText";
            this.encryptedText.Size = new System.Drawing.Size(360, 256);
            this.encryptedText.TabIndex = 2;
            this.encryptedText.Text = "";
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(7, 64);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(99, 23);
            this.decrypt.TabIndex = 1;
            this.decrypt.Text = "Розшифрувати";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // openEncrypted
            // 
            this.openEncrypted.Location = new System.Drawing.Point(6, 6);
            this.openEncrypted.Name = "openEncrypted";
            this.openEncrypted.Size = new System.Drawing.Size(99, 23);
            this.openEncrypted.TabIndex = 0;
            this.openEncrypted.Text = "Відкрити";
            this.openEncrypted.UseVisualStyleBackColor = true;
            this.openEncrypted.Click += new System.EventHandler(this.openEncrypted_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(757, 398);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.RichTextBox outText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox decryptedText;
        private System.Windows.Forms.RichTextBox encryptedText;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button openEncrypted;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button import;
    }
}

