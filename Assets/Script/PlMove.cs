using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlMove : MonoBehaviour
{
    public Transform cameraTransform;

    public CharacterController characterController;

    public float moveSpeed = 10f;
    public float jumpSpeed = 10f;
    public float gravity = -20f;
    public float yVelocity = 0;

    public Animator Enemyanimator;

    public GameObject Police;
    public Transform Spawner;

    public AudioSource Alarm;

    public bool alarm = true;


    void Start()
    {
    }

    void Update()
    {
        Move();
        Use();

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

        yVelocity += (gravity * Time.deltaTime);

        moveDirection.y = yVelocity;

        characterController.Move(moveDirection * Time.deltaTime);
    }

    void Use()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        int currentSceneIndex = currentScene.buildIndex;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 3))
            {
                if (hit.collider.CompareTag("Enemy"))
                {
                    if(currentSceneIndex == 1)
                    {
                        Enemyanimator.SetBool("Hwchu", true);
                        EnemyMove.speed = 0;
                        StartCoroutine(HwchuCool());
                        Debug.Log(currentSceneIndex);
                    }
                    if(currentSceneIndex == 2)
                    {
                        Enemyanimator.SetBool("OOF", true);
                        EnemyMove.speed = 0;
                        StartCoroutine(OOFCool());
                        Debug.Log(currentSceneIndex);
                    }
                }
            }
            if (alarm == true)
            {
                if (currentSceneIndex == 3)
                {
                    Enemyanimator.SetBool("OOF", true);
                    EnemyMove.speed = 0;
                    StartCoroutine(OOFCool());
                    Instantiate(Police, Spawner.position, Quaternion.identity);
                    Debug.Log(currentSceneIndex);
                    Alarm.Play();

                    alarm = false;
                }
            }
        }
    }

    private IEnumerator HwchuCool()
    {
        yield return new WaitForSeconds(0.8f);
        Enemyanimator.SetBool("Hwchu", false);
        EnemyMove.speed = 3f;
    }
    private IEnumerator OOFCool()
    {
        yield return new WaitForSeconds(1.2f);
        Enemyanimator.SetBool("OOF", false);
        EnemyMove.speed = 3f;
    }
}