using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security5
{
    public partial class Form1 : Form
    {
        Cryptor Cryptor;
        Decryptor Decryptor;
        public Form1()
        {
            InitializeComponent();
            Cryptor = new Cryptor();
            Decryptor = new Decryptor();
            Decryptor.D = Cryptor.D;
            Decryptor.n = Cryptor.n;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog2.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            outText.Text = Cryptor.Encrypt(textBox.Text);
            outText.Text +=  $"\n{Cryptor.getHash(textBox.Text)}";
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            textBox.Text = fileText;
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, outText.Text);
        }

        private void openEncrypted_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog2.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            encryptedText.Text = fileText;
        }

        private void decrypt_Click(object sender, EventArgs e)
        {

            var fileText = encryptedText.Text;
            if (fileText == "") return;
            int len = fileText.Split(new char[] { '\n' }).Length;
            string key = fileText.Split(new char[] { '\n' }).Skip(len - 1).First();
            string content = string.Join("", fileText.Split(new char[] { '\n' }).Take(len - 1));
            decryptedText.Text = Decryptor.Decrypt(content);
            int k = int.Parse(key);
            var res = (int)(Math.Pow(k, Decryptor.D) % Decryptor.n);
            decryptedText.Text += $"\n{res}";
            if (res == Decryptor.Sum)
                decryptedText.BackColor = Color.DarkGreen;
            else
                decryptedText.BackColor = Color.DarkRed;
        }

        private void import_Click(object sender, EventArgs e)
        {
            encryptedText.Text = outText.Text;
        }
    }
}
