using System.Collections.Generic;
using UnityEngine;

public class BatterySpawner : MonoBehaviour
{
    public GameObject Battery;
    GameObject[] spawnBatteryPoints;
    GameObject currentPoint;
    int index;
    [SerializeField]int batteryAmount = 3;

    private void Start()
    {
         while(batteryAmount > 0){
             spawnBatteryPoints = GameObject.FindGameObjectsWithTag("batterypoint"); //Finds all gameObjects with tag "batterypoint" and adds it to the array spawnBatteryPoints
             index = Random.Range(0, spawnBatteryPoints.Length); //Picks a point at random from the array
             currentPoint = spawnBatteryPoints[index]; //The point that was picked
             GameObject battery = Instantiate(Battery, currentPoint.transform.position, Quaternion.Euler(90, 0, Random.Range(0,359))); //Instantiates the battery gameObject at the point
             currentPoint.SetActive(false); //Disables the point so that no other battery can spawn there.
             currentPoint.transform.parent = battery.transform;
             Debug.Log(currentPoint.name);
             batteryAmount --;
         } 

    }
}
