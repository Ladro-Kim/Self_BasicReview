using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    GameObject player;
    float speed = 5f;

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(xInput, 0, zInput);
        dir.Normalize();

        transform.position += dir * speed * Time.deltaTime;

    }
}
