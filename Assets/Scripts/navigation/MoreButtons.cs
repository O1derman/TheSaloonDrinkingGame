using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoreButtons : MonoBehaviour
{
    public Button exitButton;
    //public Button drinkRecipesButton;
    //public Button orderAlcoholButton;
    public Button changeLanguageButton;
    //public Button supportButton;
    public Button aboutButton;

    public GameObject mainMenuScene;
    //public GameObject dringRecipesScene;
    //public GameObject orderAlcoholScene;
    public GameObject changeLanguageScene;
    //public GameObject supportScene;
    public GameObject aboutScene;
    public GameObject moreScene;

    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(exit);
        //drinkRecipesButton.onClick.AddListener(dringRecipesClick);
        //orderAlcoholButton.onClick.AddListener(orderAlcoholClick);
        changeLanguageButton.onClick.AddListener(changeLanguageClick);
        //supportButton.onClick.AddListener(supportClick);
        aboutButton.onClick.AddListener(aboutClick);
    }

    void exit()
    {
        mainMenuScene.SetActive(true);
        moreScene.SetActive(false);
    }
    //void dringRecipesClick()
    //{
    //    dringRecipesScene.SetActive(true);
    //    moreScene.SetActive(false);
    //}
    //void orderAlcoholClick()
    //{
    //    orderAlcoholScene.SetActive(true);
    //    moreScene.SetActive(false);
    //}
    void changeLanguageClick()
    {
        changeLanguageScene.SetActive(true);
        moreScene.SetActive(false);
    }
    //void supportClick()
    //{
    //    supportScene.SetActive(true);
    //    moreScene.SetActive(false);
    //}
    void aboutClick()
    {
        aboutScene.SetActive(true);
        moreScene.SetActive(false);
    }
}
