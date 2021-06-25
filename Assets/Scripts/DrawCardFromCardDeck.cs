using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;
using UnityEngine.UI;

public class DrawCardFromCardDeck : MonoBehaviour
{
    [SerializeField]
    private LocalizedStringTable _localizedStringTable;

    public List<Sprite> cards;
    public Button drawCardButton;
    public Image card;
    public TextMeshProUGUI cardText;

    private List<Sprite> cardDeck = new List<Sprite>();
    private int numOfCardsInDeck;
    private StringTable _currentStringTable;

    // Start is called before the first frame update
    [System.Obsolete]
    private IEnumerator Start()
    {
        var tableLoading = _localizedStringTable.GetTable();
        yield return tableLoading;
        _currentStringTable = tableLoading.Result;

        cardDeck.AddRange(cards);
        DrawACard();
        drawCardButton.onClick.AddListener(DrawACard);
    }

    [System.Obsolete]
    void DrawACard()
    {
        numOfCardsInDeck = cardDeck.Count;
        if (numOfCardsInDeck > 0)
        {
            int rInt = Random.RandomRange(0, numOfCardsInDeck);
            card.sprite = cardDeck[rInt];
            cardDeck.RemoveAt(rInt);

            var str = _currentStringTable[rInt.ToString()].LocalizedValue;
            cardText.text = str;
            Debug.Log(str);
        }
    }
}
