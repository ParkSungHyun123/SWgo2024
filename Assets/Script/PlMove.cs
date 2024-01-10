using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlMove : MonoBehaviour
{
    public Transform cameraTransform;

    public CharacterController characterController;

    public float moveSpeed = 10f;
    public float jumpSpeed = 10f;
    public float gravity = -20f;
    public float yVelocity = 0;

    public Animator Enemyanimator;



    void Start()
    {

    }

    void Update()
    {
        Move();
        Hwchu();

        Cursor.lockState = CursorLockMode.Locked;
    }
    void Move()
    {
        float h = Input.GetAxis("Horizontal");

        float v = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(h, 0, v);

        moveDirection = cameraTransform.TransformDirection(moveDirection);

        moveDirection *= moveSpeed;

        if (characterController.isGrounded)
        {
            yVelocity = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpSpeed;
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 13;
        }
        else
        {
            moveSpeed = 7;
        }

        yVelocity += (gravity * Time.deltaTime);

        moveDirection.y = yVelocity;

        characterController.Move(moveDirection * Time.deltaTime);
    }

    void Hwchu()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Enemy"))
                {
                    Debug.Log("Enemy에 닿았습니다!");

                    Enemyanimator.SetBool("Hwchu", true);
                }
            }
        }
    }
}