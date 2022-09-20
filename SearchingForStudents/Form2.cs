using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SearchingForStudents.Form1;
using static System.Net.Mime.MediaTypeNames;

namespace SearchingForStudents
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string[] readFile(string textFile)
        {  
            string[] lines = File.ReadAllLines(textFile);
            return lines;
        }

        public bool checkContains(string allWord, string partWord, int optionNum)
        {
            string regex;
            switch (optionNum)
            {
                case 0:     // startsWith
                    regex = $"^{partWord}.+$";
                    break;
                case 1:     // contains
                    regex = $"^.+{partWord}.+$";
                    break;
                case 2:     // endsWith
                    regex = $"^.+{partWord}$";
                    break;
                default:
                    regex = "";
                    break;
            }
            
            Regex rx = new Regex(regex,
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

            if (rx.IsMatch(allWord))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchedNames = "";
            int namePart = comboBox_FirstCriteria.SelectedIndex;
            int optionNum = comboBox_SecondCriteria.SelectedIndex;
            string[] names = readFile("C:\\Users\\student\\Source\\Repos\\Filippo0420\\SearchingForStudents\\SearchingForStudents\\Data\\uczen.txt");
            foreach(string name in names){
                string toCheck = name.Split(' ')[namePart];
                if (checkContains(toCheck, textBox_ThirdCriteria.Text, optionNum)) searchedNames += $"\t{name}";
            }
            textBox_ShowData.Text = searchedNames;
        }
    }
}
