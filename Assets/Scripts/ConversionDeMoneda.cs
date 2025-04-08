using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    public float montoAConvertir;
    public string monedaExtranjera;
    float montoConvertido;
    float cotizacionMonedaElegida;
    // Start is called before the first frame update
    void Start()
    {
        if(montoAConvertir < 1000){
            Debug.Log("El monto minimo es $1000");
            return;
        }
         if(monedaExtranjera == "D"){
              cotizacionMonedaElegida = 1070.5f;
         } else if (monedaExtranjera == "R"){
             cotizacionMonedaElegida = 181.78f;
         }else if (monedaExtranjera == "E"){
             cotizacionMonedaElegida = 1174.92f;
         }else{
             Debug.Log("Opción de moneda extranjera no valida");
         return;
         } 

        montoConvertido = montoAConvertir / cotizacionMonedaElegida;

        Debug.Log("Monto convertido: " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
