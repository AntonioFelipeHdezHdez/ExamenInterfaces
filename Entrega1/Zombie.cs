using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento del zombie
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * speed, Space.Self);  // Negativo para mover hacia atrás
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0.0f, -2.0f, 0.0f, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0.0f, 2.0f, 0.0f, Space.Self);
        }

        // Teletransportar al zombie
        if (Input.GetKey(KeyCode.T)) 
        {
            transform.position = new Vector3(0,0,2.0f);
        }
    }
}

