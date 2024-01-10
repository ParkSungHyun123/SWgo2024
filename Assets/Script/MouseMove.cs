using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    [SerializeField] private float mouseSpeed = 8f;
    private float mouseX = 0f;
    private float mouseY = 0f; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * mouseSpeed;
        mouseY += Input.GetAxis("Mouse Y") * mouseSpeed;

        mouseY = Mathf.Clamp(mouseY, -50f, 50f);

        this.transform.localEulerAngles = new Vector3(-mouseY, mouseX, 0);
    }
}