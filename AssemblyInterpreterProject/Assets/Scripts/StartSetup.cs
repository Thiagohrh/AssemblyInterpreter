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
        TextLoader instance = new TextLoader();
        string allWords = instance.ReadFromFile("example");

        string[] linesInFile = allWords.Split('\n');
        foreach (string line in linesInFile)
        {
            Debug.Log(line);
        }

        Instructions.instructions["LD"].Execute("whatever");
        Instructions.instructions["ST"].Execute("whatever");
        //To mess with teh memory array
        //Memory.memory[10] = "Whatever";

        //Use it like this to mess with teh registry
        //Debug.Log("AC: " + Registers.registry["AC"]);
    }
}
