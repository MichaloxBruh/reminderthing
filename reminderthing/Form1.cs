using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace reminderthing
{
    // TO DO
    // Randomizer numer�w przypomnie� ()
    // okno dodawania przypomnie�
    //  doda� mo�liwo�� dodania daty kiedy ma sie pojawi� / warunk�w
    // mo�liwo�� nazywania przypomnie�
    //  cos tam jeszcze...
    // make "@"C:/MF/MF_RD/MF_RD_Reminders" create itself if it doesn't exist on a computer  


    public partial class Reminderer : Form
    {
        static string path = @"C:/MF/MF_RD/MF_RD_Reminders";
        string ppppath = "@\"C:/MF/MF_RD/MF_RD_Reminders\"";
        string reminderthing = "";
        string[] pathdir = Directory.GetFiles(path, "*.txt");
        //string[] enumeratedfilepath = null;
        //C:\MF\MF_RD\MF_RD_Reminders

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            reminderthing = richTextBox1.Text;
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