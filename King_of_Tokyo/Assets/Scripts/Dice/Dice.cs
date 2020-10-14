using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    Rigidbody rb;

    bool hasLanded;
    bool rolled;

    Vector3 initPosition;

    public int diceValue;

    public DiceSide[] diceSides;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initPosition = transform.position;
        rb.useGravity = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
        }

        if(rb.IsSleeping() && !hasLanded && rolled)
        {
            hasLanded = true;
            rb.useGravity = false;
            rb.isKinematic = true;

            CheckSideValue();

        } else if(rb.IsSleeping() && hasLanded && diceValue == 0)
        {
            RollAgain();
        }
    }

    void RollDice()
    {
        if(!rolled && !hasLanded)
        {
            rolled = true;
            rb.useGravity = true;
            rb.AddTorque(Random.Range(0, 500), Random.Range(0, 500), Random.Range(0, 500));
        }
        else if (rolled && hasLanded)
        {
            Reset();
        }
    }

    void RollAgain()
    {
        Reset();

        rolled = true;
        rb.useGravity = true;
        rb.AddTorque(Random.Range(0, 500), Random.Range(0, 500), Random.Range(0, 500));
    }

    private void Reset()
    {
        transform.position = initPosition;
        rolled = false;
        hasLanded = false;
        rb.useGravity = false;
        rb.isKinematic = false;
    }

    void CheckSideValue()
    {
        diceValue = 0;

        foreach (DiceSide side in diceSides)
        {
            if (side.GetOnGround())
            {
                diceValue = side.sideValue;
                Debug.Log(diceValue + " has been rolled!");
            }
        }
    }

}
