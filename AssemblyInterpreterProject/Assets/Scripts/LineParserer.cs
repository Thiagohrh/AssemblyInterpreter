using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineParserer
{
    private bool processingData = false;
    private bool processingCode = false;
    private string[] unwantedCharacters = { ":", "#", "," };
    public void ParseLine(string line)
    {
        line = line.TrimEnd('\r', '\n');
        line = RemoveTabsAndMultipleSpaces(line);

        if (CheckForDelimiters(line))
        {
            return;
        }

        if (processingData)
        {
            ProcessDataLine(line);
        }
        else if (processingCode)
        {
            ProcessCodeLine(line);
        }
    }

    private void ProcessDataLine(string line)
    {
        line = RemoveUnwantedCharacters(line, unwantedCharacters);
        string[] elements = line.Split(' ');

        if (elements.Length == 4)
        {//Trying to create a new Registry, and allocate a memory adress related to it.
            Registers.registry[elements[0]] = int.Parse(elements[2]);
            Memory.memory[int.Parse(elements[2])] = elements[3];
        }
        else if (elements.Length == 3)
        {//Just trying to allocate a specific memory point.
            Memory.memory[int.Parse(elements[1])] = elements[2];
        }
    }
    private void ProcessCodeLine(string line)
    {
        Debug.Log("Code line to parse: " + line);
    }
    private string RemoveUnwantedCharacters(string line, string[] characters)
    {
        foreach (string character in characters)
        {
            line = line.Replace(character, string.Empty);
        }
        return line;
    }
    private string RemoveTabsAndMultipleSpaces(string line)
    {
        line = line.Replace("\t", " ");
        while (line.IndexOf("  ") >= 0)
        {
            line = line.Replace("  ", " ");
        }
        return line;
    }

    private bool CheckForDelimiters(string line)
    {
        switch (line)
        {
            case ".code":
                processingCode = true;
                return true;
            case ".endcode":
                processingCode = false;
                return true;
            case ".data":
                processingData = true;
                return true;
            case ".enddata":
                processingData = false;
                return true;
            default:
                return false;
        }
    }
}
