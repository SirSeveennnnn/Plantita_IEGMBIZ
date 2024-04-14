using UnityEngine;
using UnityEngine.UI;

public class GardenFrame : MonoBehaviour
{
    public Image plantImage;

    public void UpdateImage(Sprite sprite)
    {
        plantImage.sprite = sprite; 
    }
}
