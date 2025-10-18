using UnityEngine;

public class Even : MonoBehaviour
{
    private int _number;
   
    void Start()
    {
        //Llamarlo desde el "Start".
        GetEvenNumbers0To100For(); 
    }

   private void GetEvenNumbers0To100For()
    {
        //Si vamos sumando 2 desde el 0 solo nos aparecen los números pares.
        for (int i = 0; i < 101; i += 2) 
        {
            //Imprimir por consola.
            Debug.Log(i); 
        }
    }
}
    

