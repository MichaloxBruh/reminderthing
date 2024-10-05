using System.Text.RegularExpressions;

namespace reminderthing
{
    // TO DO
    // Randomizer numerów przypomnieñ
    //  dodaæ mo¿liwoœæ dodania daty kiedy ma sie pojawiæ / warunków
    //  cos tam jeszcze...

        

    public partial class Reminderer : Form  
    {
        string path = "C:/MF/MF_RD/MF_RD_Reminders";
        string reminderthing = "";
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
            if (Directory.Exists(path))
            {
                NumberingFile(path);

            }
            else
            {
                Directory.CreateDirectory(path);
                return;
            }
        }
    }
}

//:3