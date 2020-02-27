using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyScript : MonoBehaviour
{
    private TextMeshProUGUI money;
    private int balance;
    private string number;

    // Start is called before the first frame update
    void Start()
    {
        money = GetComponent<TextMeshProUGUI>();
        balance = 0;
    }

    // Update is called once per frame
    void Update()
    {
        number = string.Format("{0:0,0}", balance);
        money.text = "$" + number;

        if (balance < 1000000000000)
        {
            if (!PauseMenu.GameIsPaused)
            {
                balance++;
            }
        }

        

    }
}
