using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalendarTimeScript : MonoBehaviour
{
    private const int TIMESCALE = 900;

    public Text clockText;
    public Text dayText;
    public Text monthText;
    public Text yearText;

    string monthTxt;

    public static double minute, hour, day, second, month, year;

    void Start()
    {
        month = 1;
        day = 1;
        year = 2022;
        hour = 00;

    }


    void Update()
    {
        CalculateTime();
    }

    void TextCallFunction()
    {
        dayText.text =  "Day: " + day;
        clockText.text = string.Format("{0:00}:{1:00}", hour, minute);
        monthText.text = "Month: " + month;
        yearText.text = "Year: " + year;
    }

    void CalculateMonth()
    {
        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            if (day >= 32)
            {
                month++;
                day = 1;
                TextCallFunction();
         
            }
        }

        if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            if (day >= 31)
            {
                month++;
                day = 1;
                TextCallFunction();
        
            }
        }
        if (month == 2)
        {
            month++;
            day = 1;
            TextCallFunction();
       
        }

    }

    void CalculateTime()
    {
        second += Time.deltaTime * TIMESCALE;

        if (second > 60)
        {
            minute++;
            second = 0;
            TextCallFunction();
        }
        else if (minute > 60)
        {
            hour++;
            minute = 0;
            TextCallFunction();
        }
        else if (hour > 24)
        {
            day++;
            hour = 0;
            TextCallFunction();
        }
        else if (day > 28)
        {
            CalculateMonth();
        }
        else if (month > 12)
        {
            month = 1;
            year++;
            TextCallFunction();
        }

       

    }

    void MonthText()
    {
        switch (month)
        {
            case 1:
                monthTxt = "January";
                Debug.Log("January");
                break;
            case 2:
                Debug.Log("February");
                break;
            case 3:
                Debug.Log("March");
                break;
            case 4:
                Debug.Log("January");
                break;
            case 5:
                Debug.Log("January");
                break;
            case 6:
                Debug.Log("June");
                break;
            case 7:
                Debug.Log("July");
                break;
            case 8:
                Debug.Log("August");
                break;
            case 9:
                Debug.Log("September");
                break;
            case 10:
                Debug.Log("October");
                break;
            case 11:
                Debug.Log("November");
                break;
            case 12:
                Debug.Log("December");
                break;
        }
    }
}
