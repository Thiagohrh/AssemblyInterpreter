using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class MemorySlotRect : MonoBehaviour
{
    public TextMeshProUGUI textInfo;
    public TextMeshProUGUI index;

    public void SetText(string text)
    {
        textInfo.text = text;
    }
    public void SetIndex(int index)
    {
        this.index.text = index.ToString();
    }

    public void SetTextColor(Color color)
    {
        textInfo.color = color;
    }
}
