using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinTheBottleCategoryButtons : MonoBehaviour
{
    public Button exitButton;
    public Button infoButton;
    public Button basicButton;
    //public Button sexualButton;
    //public Button crazyButton;
    public Button withoutTasksButton;

    public GameObject mainMenuScene;
    public GameObject spinTheBottleHelpScene;
    public GameObject spinTheBottleGameScene;
    public GameObject spinTheBottleGameWithoutTasksScene;
    public GameObject spinTheBottleCategoryScene;

    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(exit);
        infoButton.onClick.AddListener(info);
        basicButton.onClick.AddListener(basicClick);
        //sexualButton.onClick.AddListener(changeLanguageClick);
        //crazyButton.onClick.AddListener(supportClick);
        withoutTasksButton.onClick.AddListener(withoutTasksClick);
    }

    void exit()
    {
        mainMenuScene.SetActive(true);
        spinTheBottleCategoryScene.SetActive(false);
    }
    void info()
    {
        StaticVariables.SpinTheBottleCategory = true;
        spinTheBottleHelpScene.SetActive(true);
        spinTheBottleCategoryScene.SetActive(false);
    }
    void basicClick()
    {
        spinTheBottleGameScene.SetActive(true);
        spinTheBottleCategoryScene.SetActive(false);
    }
    void withoutTasksClick()
    {
        spinTheBottleGameWithoutTasksScene.SetActive(true);
        spinTheBottleCategoryScene.SetActive(false);
    }
}
