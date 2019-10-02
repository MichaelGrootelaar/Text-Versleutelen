using System;
using System.Windows.Forms;

namespace Versleutelen
{
    public partial class Form1 : Form
    {

        private Functies functies;
        public static string FILE_NAME;

        public Form1()
        {
            InitializeComponent();
            functies = new Functies();
        }

        private void Bestand_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openDialog.FileName;
                FILE_NAME = file;
                label1.Text = file; 
            }

            openDialog.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Versleutel_Click(object sender, EventArgs e)
        {
            functies.TekstCheck(FILE_NAME, true);
        }

        private void Ontsleutel_Click(object sender, EventArgs e)
        {
            functies.TekstCheck(FILE_NAME, false);
        }
    }
}
