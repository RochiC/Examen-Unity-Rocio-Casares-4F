using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpresaDeElectricidad : MonoBehaviour
{
    public Domicilio[] domicilios;

    int a = 0, b = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Para cada domicilio generar y asignar aleatoriamente un valor booleano 
        // para su propiedad servicioElectricoActivo
        //Para cada domicilio, activar o desactivar el objeto luz 
        // de acuerdo a si la propiedad servicioElectricoActivo es verdadero o falso, respectivamente.         

        MostrarInfoEnConsola();
    }

    // Update is called once per frame
    void Update()
    {
        //Tecla C (CORTE): apaga todas las luces de todos los domicilios 
        // independientemente del valor de la propiedad servicioElectricoActivo
        if (Input.GetKeyDown(KeyCode.C))
        {
            for (int i = 0; i < domicilios.Length; i++)
            {
                domicilios[i].luzDomicilio.SetActive(false);
            }
        }
        //Tecla R(RESTITUCION): enciende las luces solo de los domicilios 
        // con servicioElectricoActivo verdadero
        if (Input.GetKeyDown(KeyCode.R))
        {
            for (int i = 0; i < domicilios.Length; i++)
            {
                if (domicilios[i].servicioElectricoActivo)
                {
                    domicilios[i].luzDomicilio.SetActive(true);
                }
            }
        }
        //Tecla T(TODOS): enciende todas las luces de todos los domicilios 
        // independientemente del valor de la propiedad servicioElectricoActivo
        if (Input.GetKeyDown(KeyCode.T))
        {
            for (int i = 0; i < domicilios.Length; i++)
            {
                domicilios[i].luzDomicilio.SetActive(true);
            }
        }
    }

    void MostrarInfoEnConsola()
    {
        //cuántos domicilios tienen su servicio eléctrico activo
        // porcentaje de domicilios con servicio eléctrico activo
        for (int i = 0; i < domicilios.Length; i++)
        {
            if (domicilios[i].servicioElectricoActivo)
            {
                a++;
            }
            b = a / domicilios.Length;
        }
        Debug.Log(a+" "+b);
    }
}
