using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipescript : MonoBehaviour
{
    public float deadZone = -2;
    public float movespeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }
}
