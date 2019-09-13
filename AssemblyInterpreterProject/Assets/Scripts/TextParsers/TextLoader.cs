using System.IO;
using UnityEngine;

public class TextLoader
{
    string folderPath = Application.dataPath + "/Resources/";
    string fileType = ".txt";
    public string ReadFromFile(string fileName)
    {
        string text = File.ReadAllText(folderPath + fileName + fileType);
        return text;
    }
}
