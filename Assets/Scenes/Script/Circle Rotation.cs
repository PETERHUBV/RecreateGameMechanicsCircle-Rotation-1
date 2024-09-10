using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CircleRotation : MonoBehaviour
{
    public float Circlespeed;
    public float switchTime;
    public Transform Rotation;
    public Vector3 DefPos;
    public bool Clockwise = true;
    public float timeelapsed = 0f;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        timeelapsed += Time.deltaTime;

        if (timeelapsed >= switchTime)
        {
            // Switch the rotation direction
            Clockwise = !Clockwise;

            // Reset the elapsed time
            timeelapsed = 0f;
        }

        float direction = Clockwise ? 1f : -1f;
       
        transform.Rotate(Vector3.forward, Circlespeed * direction  * Time.deltaTime);
       

        Debug.Log("Rotation");
    }

    }

