﻿using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace reminderthing
{
    // TO DO
    // Randomizer numerów przypomnieñ ()
    // okno dodawania przypomnieñ
    //  dodaæ mo¿liwoœæ dodania daty kiedy ma sie pojawiæ / warunków (żeby przeczytał)
    // mo¿liwoœæ nazywania przypomnieñ 
    //  cos tam jeszcze...
    


    public partial class Reminderer : Form
    {
        static string path = @"C:/MF/MF_RD/MF_RD_Reminders";
        string ppppath = @"C:/MF/MF_RD/MF_RD_Reminders";
        
        string reminderthing = "";
        //string[] pathdir = Directory.GetFiles(path, "*.txt");
        //string[] enumeratedfilepath = null;
        //C:\MF\MF_RD\MF_RD_Reminders


        public void DoesDirExist(string path2)
        {
            if (Directory.Exists(path))
            {

            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
                return;
            }

        }
        
        public static void NumberingFile(string filepath)
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
            string filename = (filepath + "/" + filenumber.ToString() + ".txt");


            FileStream fs = File.Create(filename);
            fs.Close();
            //File.Create(filename);
        }


        public Reminderer()
        {
            InitializeComponent();
            DoesDirExist(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //reminderthing = richTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
            
            
            
            /*if (Directory.Exists(path))
            {
                NumberingFile(path);

            }
            else
            {
                Directory.CreateDirectory(path);
                return;
            }*/
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Clear();
            string[] pathdir = Directory.GetFiles(path, "*.txt");
            foreach (string name in pathdir)
            {
                listView2.Items.Add(Path.GetFileNameWithoutExtension(name));
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

//:3