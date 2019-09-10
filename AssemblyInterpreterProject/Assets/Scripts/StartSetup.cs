using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSetup : MonoBehaviour
{
    void Start()
    {
        TextLoader instance = new TextLoader();
        string allWords = instance.ReadFromFile("example");


    }
}
