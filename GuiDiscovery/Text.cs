using System;
using System.Windows.Forms;

public class Text : Files
{
    private string extension = ".txt";
    public void save_text(string path, List<string> data)
    {
        System.IO.StreamWriter Save = new System.IO.StreamWriter(Directory.GetCurrentDirectory()+"/"+ path + extension);
        Save.WriteLine(data);
        foreach (var i in data)
        {
            Save.WriteLine(i);
        }
        
        Save.Close();
    }

}
