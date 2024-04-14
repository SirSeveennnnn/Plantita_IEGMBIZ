using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MyGardenHandler : MonoBehaviour
{
    public GardenData gardenData;

    public TMP_Text plantName;
    public TMP_Text scientificName;
    public Image plantImage;

    public GameObject gardenFrameTemplate;
    public GameObject whiteSpaceTemplate;
    public GameObject myGardenGallery;

    public List<GameObject> galleryObjects;


    public void OnOpenGallery(PlantData plantData)
    {
        plantName.text = plantData.plantName;
        scientificName.text = plantData.scientificName;
        plantImage.sprite = plantData.plantImage;

        for (int i = galleryObjects.Count - 1; i >= 0; i--)
        {
            Destroy(galleryObjects[i]);
        }

        List<Sprite> spritesList = new();
        switch (plantData.plantName)
        {
            case "Atis":
                spritesList = gardenData.atisList;
                break;
            case "Peanut":
                spritesList = gardenData.peanutList;
                break;
            case "SnakePlant":
                spritesList = gardenData.snakePlantList;
                break;
            case "Venus Fly Trap":
                spritesList = gardenData.venusFlyTrapList;
                break;
        }


        for (int i = 0; i < spritesList.Count; i++)
        {
            GameObject newObj = GameObject.Instantiate(gardenFrameTemplate, myGardenGallery.transform);
            GardenFrame script = newObj.GetComponent<GardenFrame>();
            script.UpdateImage(spritesList[i]);
            galleryObjects.Add(newObj);
        }

        for (int i = 0; i < 2; i++)
        {
            GameObject whiteSpace = GameObject.Instantiate(whiteSpaceTemplate, myGardenGallery.transform);
            galleryObjects.Add(whiteSpace);
        }
    }
}
