using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreButtons : MonoBehaviour
{
    public Button exitButton;

    public GameObject storeScene;
    public GameObject mainMenuScene;

    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(exit);
    }

    void exit()
    {
        mainMenuScene.SetActive(true);
        storeScene.SetActive(false);
    }
}
