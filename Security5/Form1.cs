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
        public Form1()
        {
            InitializeComponent();
            Cryptor = new Cryptor();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            outText.Text = Cryptor.Encrypt(textBox.Text);
            outText.Text +=  $"\n[{Cryptor.getHash(textBox.Text)}]";
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
    }
}
