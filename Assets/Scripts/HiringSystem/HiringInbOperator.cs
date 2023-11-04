using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiringInbOperator : MonoBehaviour
{
    public List<InbOperator> inbOperator;
    public int currentInbOperator = 0;
    public GameObject hiringInbOperatorUI;
    public static int inbOperatorSelected;

    public Text nameText;
    public Text positionText;
    public Text ageText;


    public Text unloadingText;
    public Text salaryText;


    void Start()
    {
        GenerateInbOperatorInfo();
    }

    public void GenerateInbOperatorInfo()
    {
        nameText.text = inbOperator[currentInbOperator].name;
        positionText.text = inbOperator[currentInbOperator].position;
        ageText.text = inbOperator[currentInbOperator].age.ToString();


        unloadingText.text = "Unloading: " + inbOperator[currentInbOperator].unloading.ToString() + " Trucks Per Hour";


        salaryText.text = "Salary/Month: " + inbOperator[currentInbOperator].salaryPerMonth.ToString();

    }

    public void NextEmployee()
    {
        currentInbOperator = currentInbOperator + 1;
        nameText.text = inbOperator[currentInbOperator].name;
        positionText.text = inbOperator[currentInbOperator].position;
        ageText.text = inbOperator[currentInbOperator].age.ToString();


        unloadingText.text = "Unloading: " + inbOperator[currentInbOperator].unloading.ToString() + " Trucks Per Hour";


        salaryText.text = "Salary/Month: " + inbOperator[currentInbOperator].salaryPerMonth.ToString();
    }

    public void PreviousEmployee()
    {
        currentInbOperator = currentInbOperator - 1;
        nameText.text = inbOperator[currentInbOperator].name;
        positionText.text = inbOperator[currentInbOperator].position;
        ageText.text = inbOperator[currentInbOperator].age.ToString();


        unloadingText.text = "Unloading: " + inbOperator[currentInbOperator].unloading.ToString() + " Trucks Per Hour";


        salaryText.text = "Salary/Month: " + inbOperator[currentInbOperator].salaryPerMonth.ToString();
    }

    public void HiredEmployee()
    {
        inbOperatorSelected = currentInbOperator;
        MissionManager.currentMission++;
        Destroy(hiringInbOperatorUI);

    }

    public void CloseHiringUI()
    {
        hiringInbOperatorUI.SetActive(false);
    }
}
