using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class CarSystem : MonoBehaviour
{
    public float speed = 1f;
    public bool pickup;
    public bool jeep;
    private float zValue;
    private float xValue;
    private bool facingPositive = true;

    void Update()
    {
        if (jeep)
        {
            Vector3 position = transform.position;
            xValue = Mathf.PingPong(Time.time * speed, 220);
            position.x = 280 + xValue;
            transform.position = position;

            if (xValue >= 219 && facingPositive)
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
                facingPositive = false;
            }
            else if (xValue <= 1 && !facingPositive)
            {
                transform.rotation = Quaternion.Euler(0, -90, 0);
                facingPositive = true;
            }
        }
        if(pickup)
        {
            Vector3 position = transform.position;
            zValue = Mathf.PingPong(Time.time * speed, -70);
            position.z = 300 + zValue;
            transform.position = position;

            if (zValue >= -69 && facingPositive)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                facingPositive = false;
            }
            else if (zValue <= 1 && !facingPositive)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                facingPositive = true;
            }
        }
    }
}

