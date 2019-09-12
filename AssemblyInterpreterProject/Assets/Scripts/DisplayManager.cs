using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class DisplayManager : MonoBehaviour
{
    public TextMeshProUGUI assemblyText;
    private void Start()
    {
        
    }
    public void DisplayAssemblyCodeText(string codeText)
    {
        assemblyText.text = codeText;
    }
}
