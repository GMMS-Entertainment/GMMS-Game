using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YearScript : MonoBehaviour
{
    private TextMeshProUGUI date;
    private int year;
    private int minuteCounter;

    // Start is called before the first frame update
    void Start()
    {
        date = GetComponent<TextMeshProUGUI>();
        year = 2020;
    }

    // Update is called once per frame
    void Update()
    {
        date.text = year.ToString();

        minuteCounter++;

        if (minuteCounter % 3600 == 0 && year < 2120)
        {
            if (!PauseMenu.GameIsPaused)
            {
                year++;
            }
                
        }
        //if (year => 2120)
        //{
            //GameObject.Find("endgame").GetComponent<GameOverScript>().show();       //kallar på funktion(show) i annat Script (GameOverScript)
        //}
    }
}
