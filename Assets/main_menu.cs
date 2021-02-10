using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_menu : MonoBehaviour
{
  private void Start()
  {
    Time.timeScale = 0;
  }

  public void disable_menu()
  {
    Time.timeScale = 1;
    gameObject.SetActive(false);
  }
}
