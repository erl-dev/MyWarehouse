using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Incremental : MonoBehaviour
{
    public Text moneyText;
    private const int moneyMultiplier = 3;
    private double rate;

    public static double money;
    public static double currentMoney;
    public int clientMoney;

    void Start ()
    {
        currentMoney = 1;
        rate = Time.deltaTime * moneyMultiplier;

    }
    void Update()
    {
        Increment();
        ClientMoney();
    }

    void ClientMoney()
    {
        if (ClientPickingScript.isSelected == true)
        {
            clientMoney = ClientPickingScript.contract;
        }

    }

    public void Increment()
    {
        money += rate;
        currentMoney = money;
        currentMoney += clientMoney;
        MoneyText();
    }

    void MoneyText()
    {
        moneyText.text = "₱ " + currentMoney.ToString("0");
    }

  
}
