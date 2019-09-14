using System.Collections.Generic;
using System.Linq;

public class LineParserer
{
    private bool processingData = false;
    private bool processingCode = false;
    private string[] unwantedCharacters = { ":", "#", "," };
    private int memoryPosition = 0;
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
        if (line.Contains(":"))
        {
            string[] elements = line.Split(':');
            Registers.registry[elements[0]] = memoryPosition;// <- this is a new registry item...
            List<string> dummyList = elements.ToList();
            dummyList.RemoveAt(0);
            dummyList[0] = dummyList[0].TrimStart();
            line = dummyList[0];
        }

        Memory.memory[memoryPosition] = line;

        memoryPosition++;
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
                memoryPosition = 0;
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
