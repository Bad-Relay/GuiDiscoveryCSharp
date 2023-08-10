// Est 2.5 hours
// Start 6:30 PM
// End 8:03 PM
// Added a lodaing bar 
// Added more lables to make it more user friendly 
// Also added multi threading to allow for both the loading bar and the web crawler to run at the same time 

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