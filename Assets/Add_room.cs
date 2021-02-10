using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_room : MonoBehaviour
{
    public Transform[] enemySpawners;
    private bool spawned;
    public GameObject Enemy;
    public List<GameObject> enemies;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
        spawned = true;
        foreach (Transform spawner in enemySpawners)
        {
            GameObject enemy = Instantiate(Enemy, spawner.position,Quaternion.identity) as GameObject;
            enemy.transform.parent = transform;
           // enemy.GetComponent<Enemy>().playerInRoom = true;
            enemies.Add(enemy);
        }

        StartCoroutine(CheckEnemies());
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
     //   foreach (GameObject enemy in enemies)
     //   {
     //       enemy.GetComponent<Enemy>().playerInRoom = false;
      //  }
    }

    IEnumerator CheckEnemies()
    {
        yield return new WaitForSeconds(1f);
        yield return new WaitUntil(() => enemies.Count == 0);
        open_doors();
    }

    public void open_doors()
    {
        Debug.Log("Все враги убиты");
    }
}
