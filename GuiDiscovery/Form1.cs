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
                // Reads each to the words in the word list
                IEnumerable<string> lines = File.ReadLines(fileName);

                // Run for each word in word list
                foreach (var lineRead in lines)
                {
                    
                    // adds user input with a slash and the current word in the wordlist
                    string request = textBox_url.Text + "/" + lineRead;
                    
                    try
                    {
                        // Make web request and get a response 
                        HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(request);

                        HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                        // if the request is sucessful add to the list box
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
            // if the file path user picks is possible then make that the new word list path
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
            }

        }
    }
}