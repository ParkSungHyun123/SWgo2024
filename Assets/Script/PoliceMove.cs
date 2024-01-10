using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class PoliceMove : MonoBehaviour
{
    private Transform target;
    public static float speed = 3f;

    public void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    public void Update()
    {
        Follow();
    }
    private void Follow()
    {
        transform.LookAt(target);
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * speed);
    }
}
