using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SmoothStep : MonoBehaviour
{


    //Цель (пункт Б)
    public Transform target;

    //Стартовая позиция (ось Z)
    private float _startPos;
    private float _startPosX;
    private float d;
    //Конечная позиция (ось Z)
    private float _endPosZ;
    private float _endPosX;
    public float minx;
    public float maxx;
    public float miny;
    public float maxy;


    // Use this for initialization
    void Start()
    {
        //Запоминаем начальную и конечную позиции
        _startPos = transform.position.z;
        _startPosX = transform.position.x;
        _endPosX =  Random.Range(minx, maxx); 
        _endPosZ =  Random.Range(miny, maxy); ; // target.position.z;
        
    }

    // Update is called once per frame
    void Update()
    {
           //Новая позиция по оси Z
        float _z = Mathf.SmoothStep(_startPos, _endPosZ, Time.time / 2 - d);
        float _x = Mathf.SmoothStep(_startPosX, _endPosX,Time.time / 2 - d);
 
        //Устанавливаем новую позицию
        transform.position = new Vector3(_x, transform.position.y, _z);
        
        if(_z ==_endPosZ && _x == _endPosX)
    {
        d = Time.time / 2;

            Start();
    }
    }

}