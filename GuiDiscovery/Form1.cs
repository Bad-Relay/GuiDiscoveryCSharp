using MisterHex.WebCrawling;
using System.Diagnostics;
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

        private void button_crawl_Click(object sender, EventArgs e)
        {
            // Uses a crawler libary from github.com/Misterhex/WebCrawler/tree/master
            // Takes the input from input box and searchs the html for links and does the same for each link it finds
            Crawler crawler = new Crawler();
            try
            {
                IObservable<Uri> observable = crawler.Crawl(new Uri(textBox_url.Text));
                // Adds result to listbox 
                observable.Subscribe(onNext: x => listBox_url.Items.Add(x));
            }
                    catch 
            {
                MessageBox.Show("Invaild Input");
            }
        }


        void listBox_url_DoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_url.SelectedItem != null)
            {
                //Take the current item on double click and opens it with a default web browser
                // Makes list box links clickable 
                Process.Start(new ProcessStartInfo { FileName = @listBox_url.SelectedItem.ToString(), UseShellExecute = true });
            }
        }
    }
}