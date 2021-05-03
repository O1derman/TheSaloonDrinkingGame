using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleRotation : MonoBehaviour
{

    public float tiltEffectSpeed = 500f;

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

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                if (finishedSpin)
                {
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
}
