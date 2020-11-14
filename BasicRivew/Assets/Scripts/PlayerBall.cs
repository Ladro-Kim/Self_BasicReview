using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    Rigidbody myRigid;
    float speed;
    float jumpPower;

    bool isJump;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        speed = 3;
        jumpPower = 5;
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(xInput, 0, zInput);
        dir.Normalize();

        myRigid.AddForce(dir * speed * Time.deltaTime, ForceMode.Impulse);

        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            // myRigid.velocity = Vector3.zero;
            myRigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.gameObject.layer == LayerMask.NameToLayer("Floor"))
        {
            isJump = false;
        }

        if (other.transform.gameObject.name.Contains("Final"))
        {
            // SceneManager.LoadScene(this);
        }
    }


}
