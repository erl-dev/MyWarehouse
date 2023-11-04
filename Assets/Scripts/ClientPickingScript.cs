using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientPickingScript : MonoBehaviour
{
    public List<ClientScript> clients;
    public GameObject clientUI;
    public int currentClient = 0;
    public static int clientSelected;

    public Text clientNameText;
    public Text clientDescText;
    public Text contractText;
    public Text yearText;
    public Text inbTrucksText;
    public Text otbTrucksText;
    public Image logo;

    public static int contract;
    public static int year;
    public static int inboundTruck;
    public static int outboundTruck;
    public static bool isSelected;

    void Start()
    {
        GenerateFirstClients();
    }


    public void GenerateFirstClients()
    {
        currentClient = 0;
        clientNameText.text = clients[currentClient].compName;
        clientDescText.text = clients[currentClient].compDescription;
        contractText.text = clients[currentClient].moneyYear.ToString();
        yearText.text = clients[currentClient].year.ToString();
        inbTrucksText.text = "Inbound Trucks/Day: " + clients[currentClient].inboundTrucks.ToString();
        otbTrucksText.text = "Outbound Trucks/Day: " + clients[currentClient].outboundTrucks.ToString();
        logo.sprite = clients[currentClient].compLogo;

    }

    public void NextClient()
    {
        currentClient = currentClient + 1;
        clientNameText.text = clients[currentClient].compName;
        clientDescText.text = clients[currentClient].compDescription;
        contractText.text = clients[currentClient].moneyYear.ToString();
        yearText.text = clients[currentClient].year.ToString();
        inbTrucksText.text = "Inbound Trucks/Day: " + clients[currentClient].inboundTrucks.ToString();
        otbTrucksText.text = "Outbound Trucks/Day: " + clients[currentClient].outboundTrucks.ToString();
        logo.sprite = clients[currentClient].compLogo;
    }

    public void PreviousClient()
    {
        currentClient = currentClient - 1;
       
        clientNameText.text = clients[currentClient].compName;
        clientDescText.text = clients[currentClient].compDescription;
        contractText.text = clients[currentClient].moneyYear.ToString();
        yearText.text = clients[currentClient].year.ToString();
        inbTrucksText.text = "Inbound Trucks/Day: " + clients[currentClient].inboundTrucks.ToString();
        otbTrucksText.text = "Outbound Trucks/Day: " + clients[currentClient].outboundTrucks.ToString();
        logo.sprite = clients[currentClient].compLogo;
   
       
    }

    public void ClientSelected()
    {
        clientSelected = currentClient;
        contract = clients[currentClient].moneyYear;
        year = clients[currentClient].year;
        inboundTruck = clients[currentClient].inboundTrucks;
        outboundTruck = clients[currentClient].outboundTrucks;
        isSelected = clients[currentClient].isPicked;
        isSelected = true;


        Debug.Log(clientSelected);
        Debug.Log(year);
        Debug.Log(contract);

        clientUI.SetActive(false);

    }
}
