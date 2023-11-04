using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int whsLvl;
    public int clientContract;
    public int empNum;
    public GameObject clientUI;

    public int missionNum;
    public double money;

    //employees
    public int admin;
    
    void Start()
    {
        whsLvl = 0;
        admin = 0;
        clientUI.SetActive(true);


    }

    void Update()
    {
        missionNum = MissionManager.currentMission;
        MoneyInHand();
        ClientContract();
        EmployeeMonitoring();
        empNum = admin;
    }

    public void EmployeeMonitoring()
    {
        admin = HiringAdminDisplay.adminCount;
    }

    public void ClientContract()
    {
        clientContract = ClientPickingScript.year;
    }

    public void MoneyInHand()
    {
        money = Incremental.currentMoney;
    }

    
}
