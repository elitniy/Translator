using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> words = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            words.Add("а", "a");
            words.Add("б", "b");
            words.Add("в", "v");
            words.Add("г", "g");
            words.Add("д", "d");
            words.Add("е", "e");
            words.Add("ё", "yo");
            words.Add("ж", "j");
            words.Add("з", "z");
            words.Add("и", "i");
            words.Add("й", "y");
            words.Add("к", "k");
            words.Add("л", "l");
            words.Add("м", "m");
            words.Add("н", "n");
            words.Add("о", "o");
            words.Add("п", "p");
            words.Add("р", "r");
            words.Add("с", "s");
            words.Add("т", "t");
            words.Add("у", "u");
            words.Add("ф", "f");
            words.Add("х", "h");
            words.Add("ц", "ts");
            words.Add("ч", "ç");
            words.Add("ш", "ş");
            words.Add("щ", "ş");
            words.Add("ъ", "'");
            words.Add("ы", "i");
            words.Add("ь", "'");
            words.Add("э", "e");
            words.Add("ю", "yu");
            words.Add("я", "ya");
            words.Add("А", "A");
            words.Add("Б", "B");
            words.Add("В", "V");
            words.Add("Г", "G");
            words.Add("Д", "D");
            words.Add("Е", "E");
            words.Add("Ё", "Yo");
            words.Add("Ж", "J");
            words.Add("З", "Z");
            words.Add("И", "I");
            words.Add("Й", "Y");
            words.Add("К", "K");
            words.Add("Л", "L");
            words.Add("М", "M");
            words.Add("Н", "N");
            words.Add("О", "O");
            words.Add("П", "P");
            words.Add("Р", "R");
            words.Add("С", "S");
            words.Add("Т", "T");
            words.Add("У", "U");
            words.Add("Ф", "F");
            words.Add("Х", "H");
            words.Add("Ц", "Ts");
            words.Add("Ч", "Ç");
            words.Add("Ш", "Ş");
            words.Add("Щ", "Ş");
            words.Add("Ъ", "'");
            words.Add("Ы", "I");
            words.Add("Ь", "'");
            words.Add("Э", "E");
            words.Add("Ю", "Yu");
            words.Add("Я", "Ya");
        }
        private void TextChanged_Click(object sender, EventArgs e)
        {
            string source = TraslateText.Text;
            if (comboBox.Text == "Choose")
            {
                MessageBox.Show("Make a choice for translation");
            }
            if (comboBox.Text == "Cyril-Latin")
            {
                foreach (KeyValuePair<string, string> pair in words)
                {
                    if (comboBox.Text == "Cyril-Latin") {
}
                        source = source.Replace(pair.Key, pair.Value);
                }
            }
            if (comboBox.Text == "Latin-Cyril")
            {
                foreach (KeyValuePair<string, string> pair in words)
                {
                    source = source.Replace(pair.Value, pair.Key);
                }
            }
            TranslatedText.Text = source;
        }
    }
}
