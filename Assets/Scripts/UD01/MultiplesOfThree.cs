using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    private int _number;
    
    void Start()
    {
        //Llamarlo desde el "Start".
        GetMultiplesOfThree(); 
    }

  
   void GetMultiplesOfThree()
    {
        // Al sumar 3, empezando desde el 0 nos aparecen los múltiplos de dicho número.
        for (int i = 0; i <= 101; i += 3) 
        {
            //Imprimir por consola.
            Debug.Log(i); 
        }

    }
}