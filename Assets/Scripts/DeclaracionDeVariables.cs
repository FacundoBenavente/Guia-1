using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int cantidadAlumnos;
    float kiloVendidos;
    string nombreAlumno;
    bool estaAprobado;
    // Start is called before the first frame update
    void Start()
    {
        cantidadAlumnos = 33;
        kiloVendidos = 23.7f;
        nombreAlumno = "Facu";
        estaAprobado = true;
        Debug.Log(cantidadAlumnos);
        Debug.Log(kiloVendidos);
        Debug.Log(nombreAlumno);
        Debug.Log(estaAprobado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
