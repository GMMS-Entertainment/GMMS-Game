using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyScript : MonoBehaviour
{
    private TextMeshProUGUI money;
    public long balance;
    private string abbreviation;

    // Start is called before the first frame update
    void Start()
    {
        money = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (balance >= 1000)
        {
            if ((balance.ToString().Length - 1) % 3 == 0)
            {
                money.text = balance.ToString().Remove(1) + "." + balance.ToString().Remove(0, 1).Remove(2) + abbreviation;
            }
            else if ((balance.ToString().Length - 1) % 3 == 1)
            {
                money.text = balance.ToString().Remove(2) + "." + balance.ToString().Remove(0, 2).Remove(1) + abbreviation;
            }
            else if ((balance.ToString().Length - 1) % 3 == 2)
            {
                money.text = balance.ToString().Remove(3) + abbreviation;
            }
        }
        else
        {
            money.text = balance.ToString();
        }

        if (balance.ToString().Length >= 19)
        {
            abbreviation = "qi";
        }
        else if (balance.ToString().Length >= 16)
        {
            abbreviation = "qa";
        }
        else if (balance.ToString().Length >= 13)
        {
            abbreviation = "t";
        }
        else if (balance.ToString().Length >= 10){
            abbreviation = "b";
        }
        else if (balance.ToString().Length >= 7){
            abbreviation = "m";
        }
        else
        {
            abbreviation = "k";
        }

        getMoney();
    }

    public void getMoney()
    {
        balance++;
    }
}
