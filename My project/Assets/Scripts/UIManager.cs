using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Screens")]
    [SerializeField] private GameObject mainMenuScreen;
    [SerializeField] private GameObject gardenScreen;
    [SerializeField] private GameObject growpediaScreen;
    [SerializeField] private GameObject profileScreen;

    [Header("Scroll Parents")]
    [SerializeField] private GameObject gardenContentParent;

    private void CloseAllScreens()
    {
        mainMenuScreen.SetActive(false);
        gardenScreen.SetActive(false);
        growpediaScreen.SetActive(false);
        profileScreen.SetActive(false);
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
}
