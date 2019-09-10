using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSetup : MonoBehaviour
{
    Registers registers = new Registers();
    void Start()
    {
        TextLoader instance = new TextLoader();
        string allWords = instance.ReadFromFile("example");

        Debug.Log("AC: " + Registers.registry["AC"]);
    }
}
