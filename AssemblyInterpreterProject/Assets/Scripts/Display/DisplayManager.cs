using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class DisplayManager : MonoBehaviour
{
    public TextMeshProUGUI assemblyText;
    public MemoryPanel memoryPanel;
    public RegistryPanel registryPanel;
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
        registryPanel.StartRegistry();
    }

    public void UpdateVisualPanels()
    {//Should call similar updates from the memoryPanel and the registryPanel. 
        Debug.Log("Calling UpdateVisualPanels. Currently lacking implementation.");
    }
}
