using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Domicilio : MonoBehaviour
{
    public GameObject luzDomicilio;
    public bool servicioElectricoActivo;

    // Start is called before the first frame update
    void Start()
    {
        servicioElectricoActivo = Random.Range(0, 2) == 0;
        if (servicioElectricoActivo) 
        {
            luzDomicilio.SetActive(true);
        }
        else
        {
            luzDomicilio.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
