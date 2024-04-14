using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewGardenData", menuName = "ScriptableObjects/GardenData")]
public class GardenData : ScriptableObject
{
    public List<Sprite> atisList;
    public List<Sprite> peanutList;
    public List<Sprite> snakePlantList;
    public List<Sprite> venusFlyTrapList;
}
