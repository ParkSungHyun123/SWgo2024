using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public float sesitivity = 500f;
    public float rotationX;
    public float rotationY;
    void Start()
    {

    }

    void Update()
    {
        float mouseMoveX = Input.GetAxis("Mouse X");

        float mouseMoveY = Input.GetAxis("Mouse Y");

        rotationY += mouseMoveX * sesitivity * Time.deltaTime;

        rotationX += mouseMoveY * sesitivity * Time.deltaTime;


        if (rotationX > 60f)
        {
            rotationX = 60f;
        }

        if (rotationX < -60f)
        {
            rotationX = -60f;
        }

        transform.eulerAngles = new Vector3(-rotationX, rotationY, 0);
    }
}