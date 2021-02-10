using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public int health = 10;
  private GameObject player;
  public float speed = 30.0f;
  private Add_room room;
  public bool playerInRoom;

  public void TakeDamage(int damage)
  {
    health -= damage;
Debug.Log(gameObject.name + " has taken damage");
    if (health == 0)
    {
      Destroy(gameObject);
      room.enemies.Remove(gameObject);
    }
  }

  private void Start()
  {
    player = GameObject.FindGameObjectWithTag("Player");
    room = GetComponentInParent<Add_room>();
  }

  void Update()
  {
   
    if (player != null)
    {
    if (Vector2.Distance(transform.position, player.transform.position) > 2.5)
    {
      transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
      
      Vector3 difference = player.transform.position - transform.position; 
      difference.Normalize();
      // вычисляемый необходимый угол поворота
      float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
      // Применяем поворот вокруг оси Z
      transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + 90f);    //ротация тут настраивается 
    }
    }
  }
  
  
  
  }

