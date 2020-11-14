using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItem : MonoBehaviour
{
    AudioSource audio;
    int score;
    int SCORE { get { return score; } set { score = value; } }


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Score()
    {
        score++;
        // audio.PlayScheduled(1);
    }

}
