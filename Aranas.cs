using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aranas : MonoBehaviour
{
    bool mover = false;
    // Start is called before the first frame update
    void Start()
    {
        Sillas.OnZombieCercaSilla += MoverAranas;
        ObjectController.OnTablonMirado += AlejarAranas;
    }

    // Update is called once per frame
    void Update()
    {
        // mover aranas a zombie
        if (mover)
        {
            Vector3 direccion = GameObject.Find("Zombie").transform.position - this.transform.position;
            this.transform.position += direccion.normalized * Time.deltaTime * 2.0f;
        }
    }

    private void MoverAranas()
    {
        mover = true;
    }

    private void AlejarAranas()
    {
        Vector3 direccion = GameObject.Find("Zombie").transform.position - this.transform.position;
        this.transform.position -= direccion.normalized * 2.0f;
    }
}
