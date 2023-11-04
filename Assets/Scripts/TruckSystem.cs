using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject truckPrefab;

    public int inbTrucks = 0;
    public int otbTrucks = 0;
    public float spawnIntervalInb = 2.0f; // Adjust the interval as needed
    private int truckCount = 0;

    private bool isSpawning = true; // A flag to control spawning

    private void Start()
    {
        // Call SpawnInbTruck with a delay of 0 seconds and then repeat every spawnInterval seconds.
        InvokeRepeating("SpawnInbTruck", 5f, spawnIntervalInb);
    }

    void Update()
    {
        inbTrucks = ClientPickingScript.inboundTruck;
        otbTrucks = ClientPickingScript.outboundTruck;
    }

    public void SpawnInbTruck()
    {
        if (ClientPickingScript.isSelected){
            Debug.Log("Truck Count: " + truckCount);
            Debug.Log("Inbound Trucks: " + inbTrucks);
            if (isSpawning && truckCount < inbTrucks)
            {
                Instantiate(truckPrefab, transform.position, Quaternion.identity);
                truckCount++;

                // Debugging lines
                Debug.Log("Truck spawned. Count: " + truckCount + " / " + inbTrucks);
            }
            else
            {
                // Stop spawning when the desired number of trucks is reached.
                isSpawning = false;

                // Debugging line
                Debug.Log("Truck spawning stopped.");
            }
            }
        
    }
}