using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class DisplayManager : MonoBehaviour
{
    public TextMeshProUGUI assemblyText;
    public MemoryPanel memoryPanel;
    public void StartDisplaySettings()
    {
        memoryPanel.CreateVisualMemoryPanel();
    }
    public void DisplayAssemblyCodeText(string codeText)
    {
        assemblyText.text = codeText;
    }
    public void PopulateVisualMemoryArray()
    {
        memoryPanel.PopulateVisualMemoryPanel();
    }
}
