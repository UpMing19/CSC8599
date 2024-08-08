using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorMove : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 2.0f;

    private float timeCounter = 0;
    private bool movingToPointB = true;

    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        if (movingToPointB)
        {
            transform.position = Vector3.Lerp(pointA.position, pointB.position, timeCounter);
        }
        else
        {
            transform.position = Vector3.Lerp(pointB.position, pointA.position, timeCounter);
        }

        if (timeCounter >= 1)
        {
            timeCounter = 0;
            movingToPointB = !movingToPointB;

        }
    }

}