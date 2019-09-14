using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RegistryPanel : MonoBehaviour
{
    public GameObject registrySlotRect;
    private Dictionary<string, RegisterSlotRect> registryDictionary = new Dictionary<string, RegisterSlotRect>();

    public void StartRegistry()
    {
        List<string> keyList = Registers.registry.Keys.ToList<string>();
        foreach (string key in keyList)
        {
            GameObject nSlot = Instantiate(registrySlotRect, transform);
            RegisterSlotRect nRect = nSlot.GetComponent<RegisterSlotRect>();
            registryDictionary[key] = nRect;
            nRect.SetLabel(key);
            //Remember! This should only show the memory position! Not the actual value inside it!
            nRect.SetNumber(Registers.registry[key]);
        }
    }

    public void UpdateRegistryPanel()
    {
        List<string> keyList = Registers.registry.Keys.ToList<string>();
        foreach (string key in keyList)
        {
            registryDictionary[key].SetNumber(Registers.registry[key]);
        }
    }
}
