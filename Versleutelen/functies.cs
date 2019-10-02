using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Versleutelen
{
    class Functies
    {

        private void Ontsleutelen(string path)
        {
            string text = File.ReadAllText(path);

            byte[] decrypted = Convert.FromBase64String(text);

            File.WriteAllText(path, Encoding.UTF8.GetString(decrypted));
        }

        private void Versleutelen(string path)
        {
            string text = File.ReadAllText(path);
            byte[] encoded = Encoding.UTF8.GetBytes(text);

            File.WriteAllText(path, Convert.ToBase64String(encoded));
        }

        public void TekstCheck(string path, bool versleutelen)
        {
            if (path != null && path.Substring(path.Length - 3) == "txt")
            {
                if (versleutelen)
                {
                    
                    Versleutelen(path);
                }
                else
                {
                    Ontsleutelen(path);
                }

            }
            else
            {
                MessageBox.Show("Bestand is geen 'txt' bestand.");
            }
        }
    }
}

