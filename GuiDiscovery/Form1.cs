using System.Net;
using System.Security.Policy;
using System.Windows.Forms;

namespace GuiDiscovery
{
    public partial class Form1 : Form
    {
        string fileName = @"TextFile.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                IEnumerable<string> lines = File.ReadLines(fileName);
                foreach (var lineRead in lines)
                {
                    string request = textBox_url.Text + "/" + lineRead;
                    try
                    {

                        HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(request);

                        HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();


                        if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)

                            listBox_url.Items.Add(request);

                        myHttpWebResponse.Close();
                    }
                    catch (WebException i)
                    {
                        listBox_url.Items.Add("Request failed" + " " + request + " " + i.Status);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invaild Input");
                    }

                }


            }
        }

        private void button_wl_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
            }

        }
    }
}