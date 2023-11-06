using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sillas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Tablon.OnZombieCerca += AcercarSillas;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AcercarSillas()
    {
        Vector3 direccion = GameObject.Find("Tableau").transform.position - this.transform.position;
        Debug.Log("?");
        this.transform.position += direccion.normalized;
    }

}
