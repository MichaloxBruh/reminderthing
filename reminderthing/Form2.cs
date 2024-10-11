using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reminderthing
{
    public partial class Form2 : Form
    {
        static string path = @"C:/MF/MF_RD/MF_RD_Reminders";
        string reminderthing = "";
        string[] pathdir = Directory.GetFiles(path, "*.txt");

        string remindername = "";
        string reminderdesc = "";
        string reminderdate = "";
        string reminderaddinfo = "";

        public Form2()
        {
            InitializeComponent();
        }
        
        //there is a 100% better solution to this but i'm too lazy
        public static void NumberingFile(string filepath, string remindername, string reminderdesc, string reminderdate, string reminderaddinfo)
        {

            //string[] enumeratedfilepath = null;
            //enumeratedfilepath = Directory.EnumerateFiles(filepath);

            var fileNames = Directory.GetFiles(filepath);
            var numberList = new List<int>();
            int number;

            foreach (var name in fileNames)
            {
                Match m = Regex.Match(name, "\\d+"); // this gets the number at beginning of filename
                var isNumber = Int32.TryParse(m.ToString(), out number);

                if (isNumber)
                    numberList.Add(number);
            }

            var highestfile = numberList.OrderByDescending(x => x).FirstOrDefault();
            var filenumber = (highestfile + 1);
            string filename = (filepath + "/" + remindername + " - " + filenumber.ToString() + ".txt");


            FileStream fs = File.Create(filename);
            fs.Close();
            File.SetAttributes(filename, FileAttributes.Normal);
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine(remindername);
                sw.WriteLine(reminderdesc);
                sw.WriteLine(reminderdate);
                sw.WriteLine(reminderaddinfo);
            }
            //File.Create(filename);
        }

        private void button2_Click(object sender, EventArgs e) // create button
        {
            if (remindername != "" && reminderaddinfo != "" && reminderdate != "" && reminderdesc != "")
            {
                NumberingFile(path, remindername, reminderdesc,reminderdate,reminderaddinfo);


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) //reminder name thing
        {
            remindername = (richTextBox1.Text);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e) //desc
        {
            reminderdesc = (richTextBox2.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //date
        {
            reminderdate = (dateTimePicker1.Text);
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e) //add info
        {
            reminderaddinfo = (richTextBox4.Text);
        }
    }
}
