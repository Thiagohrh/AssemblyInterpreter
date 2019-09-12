using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class RegisterSlotRect : MonoBehaviour
{
    public TextMeshProUGUI labelText;
    public TextMeshProUGUI number;

    public void SetLabel(string text)
    {
        labelText.text = text;
    }
    public void SetNumber(int index)
    {
        this.number.text = index.ToString();
    }
}
