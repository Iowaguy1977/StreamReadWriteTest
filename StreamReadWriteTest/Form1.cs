using System.IO;

namespace StreamReadWriteTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                StreamWriter streamWriter = new StreamWriter("C:\\Users\\chris\\source\\repos\\StreamReadWriteTest\\StreamTest.txt");
                streamWriter.WriteLine(StreamTxt.Text);
                streamWriter.Close();

            }
            catch (Exception exception)
            {

                MessageBox.Show("Exception: " + exception.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String line;
            try
            {
                StreamReader sr= new StreamReader("C:\\Users\\chris\\source\\repos\\StreamReadWriteTest\\StreamTest.txt");
                line= sr.ReadToEnd();
                sr.Close();
                StreamInput.Text = line;
            }
            catch (IOException exception)
            {
                MessageBox.Show("Exception: " + exception.Message);
            }
        }
    }
}
