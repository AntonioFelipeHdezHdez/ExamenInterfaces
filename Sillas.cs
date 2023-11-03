using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sillas : MonoBehaviour
{
    private GameObject zombie;
    public delegate void ZombieCercaSilla();
    public static event ZombieCercaSilla OnZombieCercaSilla;
    Vector3 posicionOriginal;
    // Start is called before the first frame update
    void Start()
    {
        zombie = GameObject.FindWithTag("Zombie");
        Tablon.OnZombieCerca += AcercarSillas;
        ObjectController.OnTablonMirado += SillasPosicionOriginal;
        posicionOriginal = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(zombie.transform.position, transform.position) < 4.0f)
        {
            OnZombieCercaSilla.Invoke();
        }   
    }

    private void AcercarSillas()
    {
        Vector3 direccion = GameObject.Find("Tableau").transform.position - this.transform.position;
        this.transform.position += direccion.normalized;
    }

    private void SillasPosicionOriginal()
    {
        transform.position = posicionOriginal;
    }
}
