using TMPro;
using UnityEngine;
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
