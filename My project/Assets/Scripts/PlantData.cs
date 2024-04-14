using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "PlantData", menuName = "ScriptableObjects/PlantData")]
public class PlantData : ScriptableObject
{
    // display
    public string plantName;
    public string scientificName;
    public Sprite plantImage;

    // plant care data
    [TextArea(5, 15)]
    public string idealClimateAndTemperature; 

    [TextArea(5, 15)]
    public string watering;

    [TextArea(5, 15)]
    public string soil;

    [TextArea(5, 15)]
    public string humidity;
}
