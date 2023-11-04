using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiringManager : MonoBehaviour
{
    public GameObject hirAdminUI;
    public GameObject hirInbCheckerUI;
    public GameObject hirInbOperatorUI;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenUI()
    {
        if (MissionManager.currentMission == 1)
        {
            hirAdminUI.SetActive(true);
        }

        if (MissionManager.currentMission == 2)
        {
            hirInbCheckerUI.SetActive(true);
        }

        if (MissionManager.currentMission == 3)
        {
            hirInbOperatorUI.SetActive(true);
        }

    }


}
