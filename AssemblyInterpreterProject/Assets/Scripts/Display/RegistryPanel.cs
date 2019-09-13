using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RegistryPanel : MonoBehaviour
{
    public GameObject registrySlotRect;
    private Dictionary<string, RegisterSlotRect> registryDictionary = new Dictionary<string, RegisterSlotRect>();

    public void StartRegistry()
    {
        List<string> keyList = Registers.registry.Keys.ToList<string>();
        //Debug.Log("Printing all of the Keys");
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

    public void UpdateRegistry()
    {

    }
}
