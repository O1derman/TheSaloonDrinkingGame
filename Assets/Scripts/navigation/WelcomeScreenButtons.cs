using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WelcomeScreenButtons : MonoBehaviour
{
    public Button letsGetDrunk;
    public GameObject mainMenuScene;
    public GameObject welcomeScene;

    // Start is called before the first frame update
    void Start()
    {
        letsGetDrunk.onClick.AddListener(letsGetDrunkClick);
    }

    void letsGetDrunkClick()
    {
        mainMenuScene.SetActive(true);
        welcomeScene.SetActive(false);
    }
}
