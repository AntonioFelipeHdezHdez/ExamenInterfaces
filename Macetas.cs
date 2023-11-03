using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Macetas : MonoBehaviour
{
    //Tablon.OnZombieCerca += MoverMacetas;
    // Start is called before the first frame update
    void Start()
    {
        Tablon.OnZombieCerca += MoverMacetas;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Ej4 mover aleatoriamente las macetas
    private void MoverMacetas()
    {
        Vector3 direccion = new Vector3(Random.Range(-7.0f, 7.0f), -5.0f, Random.Range(-7.0f,7.0f));
        this.transform.position = direccion;
    }
}
