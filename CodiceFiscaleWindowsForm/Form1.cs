using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodiceFiscaleWindowsForm
{
    public partial class Form1 : Form
    {
        private const string pathCsvMunicipality = "C:\\Users\\Ciro\\source\\repos\\corso c#\\Esercizi\\CodiceFiscaleWindowsForm\\CodiceFiscaleWindowsForm\\ElencoComuni.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void tbx_Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_GenerateCF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_Name.Text))
            {
                MessageBox.Show("Non hai inserito un nome");
                tbx_Name.ResetText();
            }
            else
            {
                var result = GenerateName(tbx_Name.Text);
            }

        }
        static string GenerateName(object name)
        {
            var nam = name.ToString().Trim();
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            foreach (char c in nam.ToLower())
            {
                if (vowels.Contains(c))
                {
                    nam.Remove(nam.IndexOf(c));
                }
            }

            return nam;
        }

    }
}
