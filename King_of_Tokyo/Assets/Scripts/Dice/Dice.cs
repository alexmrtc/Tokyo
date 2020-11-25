using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    Rigidbody rb;

    bool hasLanded;
    bool rolled;

    public bool reroll;

    Vector3 initPosition;

    public int diceValue;

    public DiceSide[] diceSides;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initPosition = transform.position;
        rb.useGravity = false;
        reroll = true;
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    RollDice();
        //}

        if (rb.IsSleeping() && !hasLanded && rolled)
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

    public void RollDice()
    {
        if (reroll == true)
        {
            if (!rolled && !hasLanded)
            {
                rolled = true;
                rb.useGravity = true;
                rb.AddTorque(Random.Range(0, 500), Random.Range(0, 500), Random.Range(0, 500));
            }
            else if (rolled && hasLanded)
            {
                Reset();
                RollAgain();
            }
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
        reroll = true;
    }

    public int CheckSideValue()
    {
        diceValue = 0;

        foreach (DiceSide side in diceSides)
        {
            if (side.GetOnGround())
            {
                SetDiceValue(side.sideValue);
                Debug.Log(diceValue + " has been rolled!");
            }
        }

        return diceValue;
    }

    private void OnMouseDown()
    {
        if(reroll == true)
        {
            reroll = false;
        } else
        {
            reroll = true;
        }
        Debug.Log(reroll);
    }

    public int GetDiceValue() { return diceValue; }
    public void SetDiceValue(int diceValueV) { diceValue = diceValueV; }

}
