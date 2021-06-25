using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLanguageButtons : MonoBehaviour
{
    public Button exitButton;

    public GameObject changeLanguageScene;
    public GameObject moreScene;

    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(exit);
    }

    void exit()
    {
        moreScene.SetActive(true);
        changeLanguageScene.SetActive(false);
    }
}