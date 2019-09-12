using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSetup : MonoBehaviour
{
    Registers registers = new Registers();
    Memory memory = new Memory();
    Instructions instructions = new Instructions();
    public DisplayManager displayManager; 
    void Start()
    {
        TextLoader textLoader = new TextLoader();
        string allWords = textLoader.ReadFromFile("example");
        displayManager.StartDisplaySettings();
        displayManager.DisplayAssemblyCodeText(allWords);

        LineParserer lineParserer = new LineParserer();
        string[] linesInFile = allWords.Split('\n');

        foreach (string line in linesInFile)
        {
            lineParserer.ParseLine(line);
        }

        displayManager.PopulateVisualMemoryArray();
    }
}
