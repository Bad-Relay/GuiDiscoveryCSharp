// Est 3 hours
// Start 7:11 PM
// End   8:28 PM
// Added a web crawler button that will search the html of a link and put it in a list box. 
// It will do the same process for each link that it finds. 
// The list box also now has clickable links so that you can open a page the program finds. 
// Was able to complete this part faster because I fond a libary for web crawling that speed up development. 
// Opening a link has a new method in .net 7.0 so I had to learn that. 

namespace GuiDiscovery
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}