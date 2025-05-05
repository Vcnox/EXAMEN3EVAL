using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenoidalMovement : MonoBehaviour
{
    public float xSpeed, ySpeed;

  
    void Update()
    {
        transform.Translate(new Vector2 (xSpeed, Mathf.Sin(Time.time) * ySpeed) * Time.deltaTime);
    }
}
