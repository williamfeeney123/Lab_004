using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip RoBlox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            AudioSource.PlayOneShot(RoBlox);
           
    }
}
