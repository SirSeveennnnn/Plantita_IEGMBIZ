using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlantHolder : MonoBehaviour
{
    public PlantData data;

    public TMP_Text plantNameText;
    public TMP_Text scientificNameText;
    public Image plantImage;

    public void ApplyPlantData()
    {
        plantNameText.text = data.plantName;
        scientificNameText.text = data.scientificName;
        plantImage.sprite = data.plantImage;
    }
}
