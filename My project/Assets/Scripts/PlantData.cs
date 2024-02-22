using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "PlantData", menuName = "ScriptableObjects/PlantData")]
public class PlantData : ScriptableObject
{
    public string plantName;
    public string scientificName;
    public Sprite plantImage;
}
