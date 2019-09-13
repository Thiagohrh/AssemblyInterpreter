using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryPanel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject memorySlotRect;
    private List<MemorySlotRect> memorySlotList = new List<MemorySlotRect>();
    public void CreateVisualMemoryPanel()
    {
        int memoryAmount = Memory.memory.Length;
        for (int i = 0; i < memoryAmount; i++)
        {
            GameObject nSlot = Instantiate(memorySlotRect, transform);
            memorySlotList.Add(nSlot.GetComponent<MemorySlotRect>());
        }
    }

    public void PopulateVisualMemoryPanel()
    {
        int memoryAmount = Memory.memory.Length;
        int counter = 0;
        foreach (MemorySlotRect slot in memorySlotList)
        {
            slot.SetIndex(counter);
            slot.SetText(Memory.memory[counter]);
            counter++;
        }
    }

    public void UpdateMemoryPanel()
    {

    }
}
