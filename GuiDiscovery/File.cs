using System;

public class Files
{

    public string fileName = "Unnamed_Export";
    public bool filepath_aviable() {
        
        // Check to see if the file is not taken 
        if (!File.Exists(Directory.GetCurrentDirectory()+ fileName + ".txt") | !File.Exists(Directory.GetCurrentDirectory() + fileName + ".txt"))
        {
            
            return true;
        }
        else {
            MessageBox.Show("File is taken");
            return false; 
        
        }
        
    }
}
