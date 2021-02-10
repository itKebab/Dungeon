using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
 private float timeBtwAttack;
 public float startTimeBtwAttack;

 public Transform attackpos;
 public LayerMask enemy;
 public float attackRange;
 public int damage;
 public Animator anim;


 private void Update()
 {
  if (timeBtwAttack <= 0)
  {
   if (Input.GetMouseButton(0))
   {
    Debug.Log("player attack");
    anim.SetTrigger("attack");
    Collider2D[] enemies = Physics2D.OverlapCircleAll(attackpos.position, attackRange, enemy);
    for (int i = 0; i < enemies.Length; i++)
    {
     enemies[i].GetComponent<Enemy>().TakeDamage(damage);
    }
    timeBtwAttack = startTimeBtwAttack;
   }
  }
  else
  {
   timeBtwAttack -= Time.deltaTime;
  }
 }

 private void OnDrawGizmosSelected()
 {
  Gizmos.color = Color.red;
  Gizmos.DrawWireSphere(attackpos.position, attackRange);
 }
}
