using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HringInbChecker : MonoBehaviour
{
    public List<InbChcker> inbChckr;
    public int currentInbChecker = 0;
    public GameObject hiringInbCheckerUI;
    public static int inbCheckerSelected;

    public Text nameText;
    public Text positionText;
    public Text ageText;
    

    public Text checkingText;
    public Text salaryText;


    void Start()
    {
        GenerateInbCheckerInfo();
    }

    public void GenerateInbCheckerInfo()
    {
        nameText.text = inbChckr[currentInbChecker].name;
        positionText.text = inbChckr[currentInbChecker].position;
        ageText.text = inbChckr[currentInbChecker].age.ToString();


        checkingText.text = "Checking: " + inbChckr[currentInbChecker].checking.ToString() + " Trucks Per Hour";
      

        salaryText.text = "Salary/Month: " + inbChckr[currentInbChecker].salaryPerMonth.ToString();

    }

    public void NextEmployee()
    {
        currentInbChecker = currentInbChecker + 1;
        nameText.text = inbChckr[currentInbChecker].name;
        positionText.text = inbChckr[currentInbChecker].position;
        ageText.text = inbChckr[currentInbChecker].age.ToString();


        checkingText.text = "Checking: " + inbChckr[currentInbChecker].checking.ToString() + " Trucks Per Hour";


        salaryText.text = "Salary/Month: " + inbChckr[currentInbChecker].salaryPerMonth.ToString();
    }

    public void PreviousEmployee()
    {
        currentInbChecker = currentInbChecker - 1;
        nameText.text = inbChckr[currentInbChecker].name;
        positionText.text = inbChckr[currentInbChecker].position;
        ageText.text = inbChckr[currentInbChecker].age.ToString();


        checkingText.text = "Checking: " + inbChckr[currentInbChecker].checking.ToString() + " Trucks Per Hour";


        salaryText.text = "Salary/Month: " + inbChckr[currentInbChecker].salaryPerMonth.ToString();
    }

    public void HiredEmployee()
    {
        inbCheckerSelected = currentInbChecker;
        MissionManager.currentMission++;
        Destroy(hiringInbCheckerUI);

    }

    public void CloseHiringUI()
    {
        hiringInbCheckerUI.SetActive(false);
    }
}
