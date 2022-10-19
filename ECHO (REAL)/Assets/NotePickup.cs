using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePickup : MonoBehaviour
{

    public AudioClip noteSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

        private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
            {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(noteSound, transform.position);
            }
    }



}

