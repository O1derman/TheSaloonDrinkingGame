using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

public class BottleRotation : MonoBehaviour
{
    [SerializeField]
    private LocalizedStringTable _localizedStringTable = null;
    public float tiltEffectSpeed = 500f;
    public TextMeshProUGUI textMPro = null;

    private StringTable _currentStringTable;
    private int len;
    private List<int> usedInts = new List<int>();

    private bool move = false;
    private bool spin = false;
    private bool spin2 = false;
    private bool spinning = false;
    private Quaternion targetRotation;
    private Quaternion curremtRotation;

    private float z;
    private float beginningZ;
    private float rotateTo;
    private int amountOfSpins;

    private bool finishedSpin = true;

    private IEnumerator Start()
    {
        // 2. Wait for the table to load asynchronously
        if (!_localizedStringTable.IsEmpty)
        {
            var tableLoading = _localizedStringTable.GetTable();
            yield return tableLoading;
            _currentStringTable = tableLoading.Result;

            len = _currentStringTable.Values.Count;
        }
    }

    [System.Obsolete]
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                if (finishedSpin && !move)
                {
                    if (textMPro != null)
                    {
                        writeNewTask();
                    }
                    move = true;
                }
            }
        }
        else if (move)
        {
            curremtRotation = transform.localRotation;
            float random_z = UnityEngine.Random.Range(curremtRotation.eulerAngles.z, curremtRotation.eulerAngles.z + 180f);
            targetRotation = Quaternion.Euler(0, 0, random_z);
            move = false;
            spin = true;
            spin2 = true;
            finishedSpin = false;
            amountOfSpins = 10;
            //amountOfSpins = UnityEngine.Random.Range(0, 4);
        }
        if (spin)
        {
            if (amountOfSpins > 0)
            {
                spinAround();
            }
            else
            {
                spin = false;
            }
        }
        else
        {
            if (spin2)
            {
                randomRotate();
            }
            else
            {
                finishedSpin = true;
            }
        }
    }

    void spinAround()
    {
        if (!spinning)
        {
            z = transform.localRotation.eulerAngles.z;
            beginningZ = z;
            spinning = true;
        }
        if (z < beginningZ + 355)
        {
            z += Time.deltaTime * tiltEffectSpeed;
            transform.localRotation = Quaternion.Euler(0, 0, z);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 0, beginningZ);
            spinning = false;
            amountOfSpins--;
            if (amountOfSpins == 0)
            {
                spin = false;
            }
        }
    }

    void randomRotate()
    {
        if (!spinning)
        {
            z = transform.localRotation.eulerAngles.z;
            beginningZ = z;
            rotateTo = UnityEngine.Random.Range(100, 360);
            spinning = true;
        }
        if (z < beginningZ + rotateTo)
        {
            z += Time.deltaTime * tiltEffectSpeed;
            transform.localRotation = Quaternion.Euler(0, 0, z);
        }
        else
        {
            spinning = false;
            spin2 = false;
        }
    }

    [System.Obsolete]
    private void writeNewTask()
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
    }
}
