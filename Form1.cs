using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ_6_1_
{
    public partial class Form1 : Form
    {
        public string path { set; get; }
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "All Filter(*.*)|*.*|Text Filter(*.txt)|*.txt";
            dialog.FilterIndex = 2;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dialog.FileName);
                writer.Write(textBox1.Text);
                writer.Close();
            }
        }

        private void openFiletoolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Filter(*.*)|*.*|Text Filter(*.txt)|*.txt";
            open.FilterIndex = 2;
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(open.FileName);
                textBox1.Text = read.ReadToEnd();
                read.Close();

            }
        }

        private void saveStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите имя файла","Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "All Filter(*.*)|*.*|Text Filter(*.txt)|*.txt";
            dialog.FilterIndex = 2;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               
                StreamWriter writer = new StreamWriter(dialog.FileName);
                writer.Write(textBox1.Text);
                writer.Close();
            }
        }

        private void CopytoolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void cuttoolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void CanceltoolStripButton_Click(object sender, EventArgs e)
        {
            if(textBox1.CanUndo == true)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = dialog.Color;
            }

        }

        private void ColorBeacktoolStripButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = dialog.Color;
            }
        }
    }
}
// новый комент 
