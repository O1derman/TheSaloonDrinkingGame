using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddAndRemoveDice : MonoBehaviour
{
    public GameObject dice;
    public Button plus;
    public Button minus;
    private int numberOfDicesOnDesk = 0;

    // Start is called before the first frame update
    void Start()
    {
        addDice();
        addDice();
        plus.onClick.AddListener(addDice);
        minus.onClick.AddListener(removeDice);
    }

    void removeDice()
    {
        if (numberOfDicesOnDesk > 1)
        {
            Destroy(this.transform.GetChild(numberOfDicesOnDesk - 1).gameObject);
            numberOfDicesOnDesk--;
        }
    }

    void addDice()
    {
        if (numberOfDicesOnDesk < 4)
        {
            GameObject newDice = Instantiate(dice);
            newDice.transform.SetParent(this.transform);
            numberOfDicesOnDesk++;
        }
    }
}
