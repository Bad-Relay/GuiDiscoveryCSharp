using System;

public class CSV : Files
{
    private string extension = ".csv";
    public void save_csv(string path, List<string> data)
    {
        System.IO.StreamWriter Save = new System.IO.StreamWriter(Directory.GetCurrentDirectory() + "/" + path + extension);
        string result = "";

        foreach (var i in data)
        {
            result +=i+","; 
        }
        Save.WriteLine(result);
        Save.Close();
    }

}
