using TMPro;
using UnityEngine;
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
    {
        memoryPanel.UpdateMemoryPanel();
        registryPanel.UpdateRegistryPanel();
    }
}
