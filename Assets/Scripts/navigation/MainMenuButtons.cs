using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    public Button spinTheBottle;
    public Button neverHaveIEver;
    public Button truthOrDare;
    public Button ringOfFire;
    public Button dice;
    public Button wouldYouRather;
    public Button drinkingGameIdeas;
    public Button more;

    public GameObject spinTheBottleObj;
    public GameObject neverHaveIEverObj;
    public GameObject truthOrDareObj;
    public GameObject ringOfFireObj;
    public GameObject diceObj;
    public GameObject wouldYouRatherObj;
    //public GameObject drinkingGameIdeasObj;
    public GameObject moreObj;

    public GameObject mainMenuScene;

    // Start is called before the first frame update
    void Start()
    {
        spinTheBottle.onClick.AddListener(spinTheBottleClick);
        neverHaveIEver.onClick.AddListener(neverHaveIEverClick);
        truthOrDare.onClick.AddListener(truthOrDareClick);
        ringOfFire.onClick.AddListener(ringOfFireClick);
        dice.onClick.AddListener(diceClick);
        wouldYouRather.onClick.AddListener(wouldYouRatherClick);
        //drinkingGameIdeas.onClick.AddListener(drinkingGameIdeasClick);
        more.onClick.AddListener(moreClick);
    }

    void spinTheBottleClick()
    {
        spinTheBottleObj.SetActive(true);
        mainMenuScene.SetActive(false);
    }
    void neverHaveIEverClick()
    {
        neverHaveIEverObj.SetActive(true);
        mainMenuScene.SetActive(false);
    }
    void truthOrDareClick()
    {
        truthOrDareObj.SetActive(true);
        mainMenuScene.SetActive(false);
    }
    void ringOfFireClick()
    {
        ringOfFireObj.SetActive(true);
        mainMenuScene.SetActive(false);
    }
    void diceClick()
    {
        diceObj.SetActive(true);
        mainMenuScene.SetActive(false);
    }
    void wouldYouRatherClick()
    {
        wouldYouRatherObj.SetActive(true);
        mainMenuScene.SetActive(false);
    }
    //void drinkingGameIdeasClick()
    //{
    //    drinkingGameIdeasObj.SetActive(true);
    //    mainMenuScene.SetActive(false);
    //}
    void moreClick()
    {
        moreObj.SetActive(true);
        mainMenuScene.SetActive(false);
    }
}
