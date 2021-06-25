using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;
using TMPro;
using UnityEngine.UI;

public class ChooseRandomTextFromTable : MonoBehaviour
{
    [SerializeField]
    private LocalizedStringTable _localizedStringTable;
    [SerializeField]
    private LocalizedStringTable _localizedStringTable2;

    public Button taskButton;
    public TextMeshProUGUI textMPro;
    public TextMeshProUGUI textMPro2 = null;
    public GameObject newQuestionsGameObject = null;
    private StringTable _currentStringTable;
    private StringTable _currentStringTable2 = null;
    private int len;
    private List<int> usedInts = new List<int>();
    private string gamesName;
    private string gamesName2;

    [System.Obsolete]
    private IEnumerator Start()
    {
        gamesName = transform.parent.parent.name;
        gamesName2 = transform.parent.name;
        int rInt;
        // 2. Wait for the table to load asynchronously
        var tableLoading = _localizedStringTable.GetTable();
        yield return tableLoading;
        _currentStringTable = tableLoading.Result;

        if (gamesName2.Equals("WouldYouRatherGame"))
        {
            var tableLoading2 = _localizedStringTable2.GetTable();
            yield return tableLoading2;
            _currentStringTable2 = tableLoading2.Result;
        }

        // At this point _currentStringTable can be used to
        // access our strings
        // 3. Retrieve the localized string
        len = _currentStringTable.Values.Count;
        if (!gamesName.Equals("TruthOrDareGame"))
        {
            rInt = Random.RandomRange(1, len + 1); //for ints
            usedInts.Add(rInt);
            var str = _currentStringTable[rInt.ToString()].LocalizedValue;
            textMPro.text = str;
            Debug.Log(str);

            if (gamesName2.Equals("WouldYouRatherGame"))
            {
                str = _currentStringTable2[rInt.ToString()].LocalizedValue;
                textMPro2.text = str;
                Debug.Log(str);
            }
        }

        taskButton.onClick.AddListener(TaskOnClick);
    }

    [System.Obsolete]
    void TaskOnClick()
    {
        int rInt = Random.RandomRange(1, len + 1); //for ints
        if (usedInts.Count == len)
        {
            usedInts.Clear();
        }
        while (usedInts.Contains(rInt))
        {
            rInt = Random.RandomRange(1, len + 1); //for ints
        }
        usedInts.Add(rInt);
        var str = _currentStringTable[rInt.ToString()].LocalizedValue;
        textMPro.text = str;
        Debug.Log(str);

        if (gamesName2.Equals("WouldYouRatherGame"))
        {
            str = _currentStringTable2[rInt.ToString()].LocalizedValue;
            textMPro2.text = str;
            Debug.Log(str);
        }

        if (gamesName.Equals("TruthOrDareGame"))
        {
            if (newQuestionsGameObject != null)
            {
                newQuestionsGameObject.SetActive(true);
            }
        }
    }
}
