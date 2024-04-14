using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Screens")]
    [SerializeField] private GameObject mainMenuScreen;
    [SerializeField] private GameObject gardenScreen;
    [SerializeField] private GameObject growpediaScreen;
    [SerializeField] private GameObject profileScreen;
    [SerializeField] private GameObject expertHelpScreen;
    [SerializeField] private GameObject plantInfoScreen;
    [SerializeField] private GameObject myGardenScreen;

    [Header("Scroll Parents")]
    [SerializeField] private GameObject gardenContentParent;

    [Space(10)]
    public PlantInfoHandler infoHandler;
    public MyGardenHandler myGardenHandler;


    private void CloseAllScreens()
    {
        mainMenuScreen.SetActive(false);
        gardenScreen.SetActive(false);
        growpediaScreen.SetActive(false);
        profileScreen.SetActive(false);
        expertHelpScreen.SetActive(false);
        plantInfoScreen.SetActive(false);
        myGardenScreen.SetActive(false);
    }

    public void OpenMainMenu()
    {
        CloseAllScreens();
        mainMenuScreen.SetActive(true);
    }

    public void OpenGardenScreen()
    {
        CloseAllScreens();
        gardenScreen.SetActive(true);
    }

    public void OpenGrowpediaScreen()
    {
        CloseAllScreens();
        growpediaScreen.SetActive(true);
    }

    public void OpenProfile()
    {
        CloseAllScreens();
        profileScreen.SetActive(true);
    }

    public void OpenExpertHelpScreen()
    {
        CloseAllScreens();
        expertHelpScreen.SetActive(true);
    }

    public void OpenPlantInfoScreen(PlantHolder holder)
    {
        CloseAllScreens();
        infoHandler.UpdateData(holder.data);
        plantInfoScreen.SetActive(true);
    }

    public void OpenMyGardenScreen(PlantData plantData)
    {
        CloseAllScreens();
        myGardenHandler.OnOpenGallery(plantData);
        myGardenScreen.SetActive(true);
    }
}
