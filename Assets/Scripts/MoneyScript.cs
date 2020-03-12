using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyScript : MonoBehaviour
{
    private TextMeshProUGUI money;
    private int balance;

    // Start is called before the first frame update
    void Start()
    {
        money = GetComponent<TextMeshProUGUI>();
        balance = 0;
    }

    // Update is called once per frame
    void Update()
    {
        money.text = balance.ToString();
    }

    public void getMoney()
    {
        if (balance < 1000000000)
        {
            balance++;
        }
    }
}
