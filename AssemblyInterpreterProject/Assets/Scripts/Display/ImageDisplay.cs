using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageDisplay : MonoBehaviour
{
    private static Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        //Create the texture
        Texture2D texture2D = new Texture2D(10, 10);
        for (int x = 0; x < texture2D.width; x++)
        {
            for (int y = 0; y < texture2D.height; y++)
            {
                texture2D.SetPixel(x, y, Color.white);
            }
        }
        texture2D.Apply();
        texture2D.filterMode = FilterMode.Point;
        //Create new sprite in order to render the texture...
        Sprite newSprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), Vector2.one * 0.5f);
        //assign our procedural sprite to renderer.sprite.
        image.sprite = newSprite;
    }

    public static void DrawPixelOnScreen()
    {
        image.sprite.texture.SetPixel(Registers.DrawCursor.X, Registers.DrawCursor.Y, 
            new Color(Registers.registry["AC"], Registers.registry["AC2"], Registers.registry["AC3"]));
        image.sprite.texture.Apply();
    }
}
