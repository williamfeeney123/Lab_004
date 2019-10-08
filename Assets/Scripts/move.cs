using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 startPosition = new Vector2(transform.position.x, transform.position.y);
        transform.position = startPosition;

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + .1f, transform.position.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - .1f, transform.position.y);
        }
    }
}
