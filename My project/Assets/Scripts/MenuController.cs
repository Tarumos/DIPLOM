using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] screens;

    public void SelectScreen(string screenName)
    {
        if (screenName == "main")
        {
            screens[0].SetActive(true);
            screens[1].SetActive(false);
        }
        else if (screenName == "select")
        {
            screens[0].SetActive(false);
            screens[1].SetActive(true);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
