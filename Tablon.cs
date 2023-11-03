using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablon : MonoBehaviour
{
    private GameObject zombie;
    public delegate void ZombieCerca();
    public static event ZombieCerca OnZombieCerca;
    private bool dentro = false;
    // Start is called before the first frame update
    void Start()
    {
        zombie = GameObject.FindWithTag("Zombie");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(zombie.transform.position, transform.position) < 8.0f && dentro == false)
        {
            dentro = true;
            OnZombieCerca.Invoke();
        } else if (Vector3.Distance(zombie.transform.position, transform.position) > 8.0f)
        {
            dentro = false;
        }
    }

}
