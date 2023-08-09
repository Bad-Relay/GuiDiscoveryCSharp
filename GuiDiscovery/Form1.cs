using MisterHex.WebCrawling;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            //Crawler crawler = new Crawler();

            // IObservable<Uri> observable = crawler.Crawl(new Uri(textBox_url.Text));
            // Adds result to listbox 
            //  observable.Subscribe(onNext: x => listBox_url.Items.Add(x));

            List<string> url_crawl = new List<string>();

            url_crawl = look_for_links(textBox_url.Text); //stores the found links 

            for (int i = 0; i < Int32.Parse(comboBox_layers.Text); i++)
            {
                foreach (string u in url_crawl)
                {

                    url_crawl = url_crawl.Concat(look_for_links(u)).Distinct().ToList();
                }
            }

            url_crawl = url_crawl.Concat(url_crawl).Distinct().ToList();
            try
            {
                foreach (string a in url_crawl)
                {
                    listBox_url.Items.Add(a);
                }
            }
            catch { }

            url_crawl.Clear();
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

        static List<string> look_for_links(string url)
        {
            List<string> url_found = new List<string>();

            WebClient client = new WebClient();

            
            try
            {
                // Download html of user input
                string url_link = client.DownloadString(url);

                //Uses regx to look for the website links in the html
                // looks for a url that starts with https, ftp, file or http with :// affter 
                Regex regx = new Regex(@"\b(https?|ftp|file|http)://\S+", RegexOptions.IgnoreCase);
                MatchCollection mactches = regx.Matches(url_link);

                foreach (Match match in mactches)
                {

                    url_found.Add(match.Value.ToString());
                }
            }
            catch { }
            return url_found;

        }

        private void button_export_Click(object sender, EventArgs e)
        {
            Files f = new Files();
            if (!string.IsNullOrWhiteSpace(textBox_Name.Text.ToString()))
            {
                f.fileName = textBox_Name.Text.ToString();
            }
            
            if (f.filepath_aviable() == true)
            {
                //make listbox into normal list
                var list_listbox = listBox_url.Items.Cast<String>().ToList();

                switch (comboBox_file.Text.ToString())
                {
                    case "Text":
                        Text t = new Text();
                        t.save_text(f.fileName,list_listbox);
                        break;
                    case "CSV":
                        CSV c = new CSV();
                        c.save_csv(f.fileName,list_listbox);
                        break;
                }

            }
        }
    }
}