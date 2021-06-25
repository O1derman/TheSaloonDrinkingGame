using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinTheBottleGameButtons : MonoBehaviour
{
    public Button exitButton;
    public Button infoButton;

    public GameObject spinTheBottleCategoryScene;
    public GameObject spinTheBottleHelpScene;
    public GameObject spinTheBottleGameScene;

    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(exit);
        infoButton.onClick.AddListener(info);
    }

    void exit()
    {
        spinTheBottleCategoryScene.SetActive(true);
        spinTheBottleGameScene.SetActive(false);
    }
    void info()
    {
        if (transform.name.Equals("SpinTheBottleGameWithoutTasks"))
        {
            StaticVariables.GameWithoutTasks = true;
        }
        spinTheBottleHelpScene.SetActive(true);
        spinTheBottleGameScene.SetActive(false);
    }
}
