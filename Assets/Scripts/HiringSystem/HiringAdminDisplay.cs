using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiringAdminDisplay : MonoBehaviour
{
    public List<AdminStaffSerializable> admin;
    public GameObject adminStaff;
    public int currentAdmin = 0;
    public GameObject hiringAdminUI;
    public static int adminSelected;

    public Text nameText;
    public Text positionText;
    public Text ageText;
    public Text genderText;

    public Text communicationText;
    public Text analyticalText;
    public Text potentialText;

    public Text salaryText;


    public static int adminCount;

    void Start()
    {
        GenerateAdminInfo();
    }

    public void GenerateAdminInfo()
    {
        nameText.text = admin[currentAdmin].name;
        positionText.text = admin[currentAdmin].position;
        ageText.text = admin[currentAdmin].age.ToString();
        genderText.text = admin[currentAdmin].gender;

        communicationText.text = "Communication: " + admin[currentAdmin].communication.ToString();
        analyticalText.text = "Analytical: " + admin[currentAdmin].analytical.ToString();
        potentialText.text = "Potential: " + admin[currentAdmin].potential.ToString();

        salaryText.text = "Salary/Month: " + admin[currentAdmin].salaryPerMonth.ToString();

    }

    public void NextAdmin()
    {
        currentAdmin = currentAdmin + 1;
        nameText.text = admin[currentAdmin].name;
        positionText.text = admin[currentAdmin].position;
        ageText.text = admin[currentAdmin].age.ToString();
        genderText.text = admin[currentAdmin].gender;

        communicationText.text = "Communication: " + admin[currentAdmin].communication.ToString();
        analyticalText.text = "Analytical: " + admin[currentAdmin].analytical.ToString();
        potentialText.text = "Potential: " + admin[currentAdmin].potential.ToString();

        salaryText.text = "Salary/Month: " + admin[currentAdmin].salaryPerMonth.ToString();
    }

    public void PreviousAdmin()
    {
        currentAdmin = currentAdmin - 1;
        nameText.text = admin[currentAdmin].name;
        positionText.text = admin[currentAdmin].position;
        ageText.text = admin[currentAdmin].age.ToString();
        genderText.text = admin[currentAdmin].gender;

        communicationText.text = "Communication: " + admin[currentAdmin].communication.ToString();
        analyticalText.text = "Analytical: " + admin[currentAdmin].analytical.ToString();
        potentialText.text = "Potential: " + admin[currentAdmin].potential.ToString();

        salaryText.text = "Salary/Month: " + admin[currentAdmin].salaryPerMonth.ToString();
    }

    public void HiredAdmin()
    {

        adminSelected = currentAdmin;
        adminCount = 1;
        Instantiate(adminStaff);
        MissionManager.currentMission++;
        Destroy(hiringAdminUI);

    }

    public void CloseAdminUI()
    {
        hiringAdminUI.SetActive(false);
    }
}
