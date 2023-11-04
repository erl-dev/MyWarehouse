using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionManager : MonoBehaviour
{
    public List<MissionScript> missions;
    public static int currentMission = 0;
    public GameObject missionUI;
  
    public Text titleText;
    public Text descriptionText;

    void Start()
    {
        missionUI.SetActive(false);
        
        currentMission = 0;

    }

    void Update()
    {
        GenerateMission();
        CompletedMission();
        
    }

 
   public void GenerateMission()
    {
       
        titleText.text = missions[currentMission].title;
        descriptionText.text = missions[currentMission].description;
       
        
    }

    public void CompletedMission()
    {
        if (currentMission == 0)
        {
            if (ClientPickingScript.isSelected == true)
            {
                missions[0].completed = true;
                currentMission++;
                
            }
           
        }
    }


    public void OpenQuestWindw()
    {
        missionUI.SetActive(true);
       
    }

    public void CloseMissionWindw()
    {
        missionUI.SetActive(false);

    }

  
}
