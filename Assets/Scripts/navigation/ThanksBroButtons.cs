using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThanksBroButtons : MonoBehaviour
{
    public Button exitButton;

    public GameObject thanksBroScene;
    public GameObject mainMenuScene;

    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(exit);
    }

    void exit()
    {
        mainMenuScene.SetActive(true);
        thanksBroScene.SetActive(false);
    }
}