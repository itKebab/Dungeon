using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room_mover : MonoBehaviour
{
    public Vector3 cameraChangePos;
    public Vector3 playerChangePos;
    public Vector3 _endPos;
    private Camera cam;
    float _velocity = 50;
    private bool triger = false;
    private void Start()
    {
        cam = Camera.main.GetComponent<Camera>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //other.transform.rotation = new Quaternion(0f,0f,0f, 0f);
            Debug.Log("door_trigger");
        other.transform.position += playerChangePos;
        _endPos =  cam.transform.position + cameraChangePos;
        triger = true;
        Debug.Log("triger true");
        }
    }



    void Update()
    {
        if (triger)
        {
        cam.transform.position = Vector3.MoveTowards(cam.transform.position, _endPos, Time.deltaTime * _velocity);
        Debug.Log("anim camera");
        if (cam.transform.position == _endPos)
        {
            triger = false;
            Debug.Log("triger false");
        }
        }
    }

}
