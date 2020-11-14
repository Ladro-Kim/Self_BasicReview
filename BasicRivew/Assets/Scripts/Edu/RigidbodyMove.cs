using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMove : MonoBehaviour
{

    Rigidbody myRigid;

    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        // myRigid.AddForce(Vector3.up * 10f, ForceMode.Force);
        // myRigid.velocity = Vector3.right;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            myRigid.velocity = Vector3.zero;
            myRigid.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }

        Vector3 dir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        myRigid.AddForce(dir * 5f * Time.deltaTime, ForceMode.Impulse);

        //if (Input.GetKey(KeyCode.W))
        //{
        //    myRigid.velocity = transform.forward;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    myRigid.velocity = -transform.forward;
        //}

        // myRigid.AddTorque(new Vector3(0, 1, 0));

    }

    private void OnTriggerStay(Collider other)
    {
        myRigid.AddForce(Vector3.up, ForceMode.Impulse);
    }

}
