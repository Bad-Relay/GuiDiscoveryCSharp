// Est 3 hours
// Start 10:00 PM
// End 11:18 PM
// Started the base of the program where it can read a word list and make a request. 
// The user can also add a custom word list with the word list button
// For debugging right now if a web request is failed it will say what the error is 
// The time was done faster because of examples of functions from learn.microsoft.com
// User needs to add the portcol but that can be a drop down in the next update
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