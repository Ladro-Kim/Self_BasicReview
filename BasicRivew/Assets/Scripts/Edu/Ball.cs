using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody myRigid;
    MeshRenderer mr;
    Material mat;

    bool isTouched;

    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mat = mr.material;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.name.Contains("Player"))
        {
            mat.color = Color.red;
        }

    }

    private void OnCollisionStay(Collision other)
    {
        if (other.transform.name.Contains("Player"))
        {

            mat.color = Color.yellow;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.transform.name.Contains("Player"))
        {

            mat.color = new Color32(13, 168, 99, 255);
        }
    }





}
