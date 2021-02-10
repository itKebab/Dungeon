using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Random = UnityEngine.Random;

public class roomGenerator : MonoBehaviour
{
   public Direction direction;
   
   public enum Direction
   {
      Top,
      Bottom,
      Left,
      Rigtht,
      none
   }

   private roomVariants variants;
   private int rand;
   private bool spawned = false;
   private float waotTime = 3f;

   private void Start()
   {
      variants = GameObject.FindWithTag("rooms").GetComponent<roomVariants>();
      Destroy(gameObject, waotTime);
      Invoke("Spawn", 0.2f);
   }

   public void Spawn()
   {
      if (!spawned)
      {
         if (direction == Direction.Top)
         {
            rand = Random.Range(0, variants.topRooms.Length);
            Instantiate(variants.topRooms[rand], transform.position, variants.topRooms[rand].transform.rotation);
         }
         if (direction == Direction.Bottom)
         {
            rand = Random.Range(0, variants.downRooms.Length);
            Instantiate(variants.downRooms[rand], transform.position, variants.downRooms[rand].transform.rotation);
         }
         if (direction == Direction.Left)
         {
            rand = Random.Range(0, variants.leftRooms.Length);
            Instantiate(variants.leftRooms[rand], transform.position, variants.leftRooms[rand].transform.rotation);
         }
         if (direction == Direction.Rigtht)
         {
            rand = Random.Range(0, variants.rightRooms.Length);
            Instantiate(variants.rightRooms[rand], transform.position, variants.rightRooms[rand].transform.rotation);
         }
         spawned = true;
      }
   }

   private void OnTriggerStay2D(Collider2D other)
   {
      if (other.CompareTag("room") && other.GetComponent<roomGenerator>().spawned)
      {
         Debug.Log("Destroy room point");
         Destroy(gameObject);
      }
   }
}
