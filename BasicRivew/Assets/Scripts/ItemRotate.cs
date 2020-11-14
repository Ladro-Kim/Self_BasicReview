using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotate : MonoBehaviour
{
    float rotSpeed;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        rotSpeed =15;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            PlayerItem playerItem = other.gameObject.GetComponent<PlayerItem>();
            playerItem.Score();
            gameObject.SetActive(false);

        }

    }


}
