using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinTheBottleHowToPlayButtons : MonoBehaviour
{
    public Button exitButton;

    public GameObject spinTheBottleCategoryScene;
    public GameObject spinTheBottleGameScene;
    public GameObject spinTheBottleGameWithoutTasksScene;
    public GameObject spinTheBottleHelpScene;

    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(exit);
    }

    void exit()
    {
        if (StaticVariables.SpinTheBottleCategory)
        {
            StaticVariables.SpinTheBottleCategory = false;
            spinTheBottleCategoryScene.SetActive(true);

        }
        else if (StaticVariables.GameWithoutTasks)
        {
            StaticVariables.GameWithoutTasks = false;
            spinTheBottleGameWithoutTasksScene.SetActive(true);

        }
        else
        {
            spinTheBottleGameScene.SetActive(true);

        }
        spinTheBottleHelpScene.SetActive(false);
    }
}