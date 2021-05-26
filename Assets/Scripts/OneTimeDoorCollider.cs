using System;
using System.Collections;
using UnityEngine;

public class OneTimeDoorCollider : MonoBehaviour
{
   [SerializeField] EnemySpawner enemyspawner;
   private int usesBeforeNormal;
    void Start()
    {
        usesBeforeNormal = 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && usesBeforeNormal > 0)
        {
            Door door = GetComponentInChildren<Door>();
            enemyspawner.spawnEnemy();
            door.OpenCloseDoor();
            door.isLocked = true;
            usesBeforeNormal--;
        }
    }
}
