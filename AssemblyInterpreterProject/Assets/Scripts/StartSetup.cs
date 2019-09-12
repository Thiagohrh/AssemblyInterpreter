using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSetup : MonoBehaviour
{
    Registers registers = new Registers();
    Memory memory = new Memory();
    Instructions instructions = new Instructions();
    void Start()
    {
        TextLoader textLoader = new TextLoader();
        string allWords = textLoader.ReadFromFile("example");

        LineParserer lineParserer = new LineParserer();
        string[] linesInFile = allWords.Split('\n');

        foreach (string line in linesInFile)
        {
            lineParserer.ParseLine(line);
        }

        Instructions.instructions["LD"].Execute("whatever");
        Instructions.instructions["ST"].Execute("whatever");
        //To mess with teh memory array
        //Memory.memory[10] = "Whatever";

        //Use it like this to mess with teh registry
        //Debug.Log("AC: " + Registers.registry["AC"]);
    }

}
