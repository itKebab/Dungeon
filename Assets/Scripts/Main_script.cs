using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class Main_script : MonoBehaviour
{
    public Transform menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void restart()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void close_menu()
    {
        menu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menu.gameObject.SetActive(true);
        }
        
    }
}
