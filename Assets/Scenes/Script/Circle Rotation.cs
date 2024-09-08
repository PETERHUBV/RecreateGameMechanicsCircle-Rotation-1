using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CircleRotation : MonoBehaviour
{
    public float Circlespeed;
    public bool  CircleSpin = true;


    // Start is called before the first frame update
    void Start()
    {
     
        

    }

    // Update is called once per frame
    void Update()
    {
        float Direction = CircleSpin ? 1.0f : -1.0f;
        transform.Rotate(Vector3.up,Circlespeed  * Time.deltaTime);


    }
}
