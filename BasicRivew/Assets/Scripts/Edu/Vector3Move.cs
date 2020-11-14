using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Move : MonoBehaviour
{

    public float speed;

    void Start()
    {
        speed = 0.01f;
    }

    void Update()
    {
        // transform.position = Vector3.MoveTowards(transform.position, Vector3.up * 20f, speed);
        // Vector3 velo = Vector3.zero;
        // transform.position = Vector3.SmoothDamp(transform.position, Vector3.forward * 10f, ref velo, 0.1f);
        // transform.position = Vector3.Lerp(transform.position, Vector3.forward * 5f, 0.1f);
        // transform.position = Vector3.Slerp(transform.position, Vector3.forward * 5f, 1f * Time.deltaTime);
    }
}
