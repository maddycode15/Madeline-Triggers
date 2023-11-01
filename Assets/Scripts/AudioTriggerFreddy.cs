using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioTriggerFreddy : MonoBehaviour
{
   private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();

        

        // Update is called once per frame
        void Update()
        {

        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))

        {
            audio.Play();

        }
    }

}
