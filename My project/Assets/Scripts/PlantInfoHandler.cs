using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlantInfoHandler : MonoBehaviour
{
    public TMP_Text plantName;
    public TMP_Text scientificName;
    public Image plantImage;

    public TMP_Text idealClimateAndTemperature;
    public TMP_Text watering;
    public TMP_Text soil;
    public TMP_Text humidity;

    public void UpdateData(PlantData data)
    {
        plantName.text = data.plantName;
        scientificName.text = data.scientificName;
        plantImage.sprite = data.plantImage;

        idealClimateAndTemperature.text = data.idealClimateAndTemperature;
        watering.text = data.watering;
        soil.text = data.soil;
        humidity.text = data.humidity;
    }
}
