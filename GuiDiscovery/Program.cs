// Est 2.5 hours
// Start 6:30 PM
// End 10:35 PM
// Remade the web crawler so you can see how many links deep you can go into
// Added a function for finding links in the html so it can be repeated easily 
// Added a exprot function to put the listbox resuts in a text file 
// Added a main file class that can also check if a path is aviable 
// Added a txt and csv class that come from the file class 

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