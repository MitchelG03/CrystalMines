using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsCave : MonoBehaviour

{
    public AudioSource Footsteps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {

        }
        else
        {
            Footsteps.Play();
        }
    }
}
