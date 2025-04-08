using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayorValor : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    // Start is called before the first frame update
    void Start()
    {
        if(num1 > num2 && num1 > num3){
            Debug.Log("El mayor numero es num1");
            } else if(num2 > num1 && num2 > num3){
            Debug.Log("El mayor numero es num2")
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
