using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AboutButtons : MonoBehaviour
{
    public Button exitButton;

    public GameObject aboutScene;
    public GameObject moreScene;

    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(exit);
    }

    void exit()
    {
        moreScene.SetActive(true);
        aboutScene.SetActive(false);
    }
}
