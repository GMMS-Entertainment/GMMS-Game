using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YearScript : MonoBehaviour
{
    private TextMeshProUGUI year;
    public TextMeshProUGUI month;
    public TextMeshProUGUI date;
    private int yearNumber;
    private int monthNumber;
    private int dayNumber;
    private string monthName;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        year = GetComponent<TextMeshProUGUI>();
        if (!month)
        {
            month = GameObject.Find("month").GetComponent<TextMeshProUGUI>();
        }
        if (!date)
        {
            date = GameObject.Find("date").GetComponent<TextMeshProUGUI>();
        }
        yearNumber = 2020;
        monthNumber = 1;
        dayNumber = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        month.text = monthName;
        date.text = dayNumber.ToString();
        year.text = yearNumber.ToString();

        counter++;

        if(counter % 10 == 0 && yearNumber < 2120)
        {
            dayNumber++;

            if (dayNumber % 32 == 0 && (monthNumber == 1 || monthNumber == 3 || monthNumber == 5 || monthNumber == 7 || monthNumber == 8 || monthNumber == 10 || monthNumber == 12))
            {
                monthNumber++;
                dayNumber = 1;
                if (monthNumber == 13)
                {
                    yearNumber++;
                    monthNumber = 1;
                }
            }
            else if (dayNumber % 31 == 0 && (monthNumber == 4 || monthNumber == 6 || monthNumber == 9 || monthNumber == 11))
            {
                monthNumber++;
                dayNumber = 1;
            }
            else if (dayNumber % 30 == 0 && monthNumber == 2 && ((yearNumber % 4 == 0 && yearNumber % 100 !=0) || yearNumber % 400 == 0))
            {
                monthNumber++;
                dayNumber = 1;
            }
            else if (dayNumber % 29 == 0 && monthNumber == 2 && yearNumber % 4 != 0)
            {
                monthNumber++;
                dayNumber = 1;
            }
        }

        if (monthNumber == 1)
        {
            monthName = "Jan";
        }
        else if (monthNumber == 2)
        {
            monthName = "Feb";
        }
        else if (monthNumber == 3)
        {
            monthName = "Mar";
        }
        else if (monthNumber == 4)
        {
            monthName = "Apr";
        }
        else if (monthNumber == 5)
        {
            monthName = "May";
        }
        else if (monthNumber == 6)
        {
            monthName = "Jun";
        }
        else if (monthNumber == 7)
        {
            monthName = "Jul";
        }
        else if (monthNumber == 8)
        {
            monthName = "Aug";
        }
        else if (monthNumber == 9)
        {
            monthName = "Sep";
        }
        else if (monthNumber == 10)
        {
            monthName = "Oct";
        }
        else if (monthNumber == 11)
        {
            monthName = "Nov";
        }
        else if (monthNumber == 12)
        {
            monthName = "Dec";
        }
    }
}
