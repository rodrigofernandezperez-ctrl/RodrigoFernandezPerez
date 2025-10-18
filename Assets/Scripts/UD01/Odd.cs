using UnityEngine;

public class Odd : MonoBehaviour
{
    private int _number;
   
    void Start()
    {
        GetEvenNumbers0To100For();
    }

    private void GetEvenNumbers0To100For()
    {
        //Empezamos en 1 y sumamos 2 para mantener el impar.
        for (int i = 1; i < 101; i += 2) 
        {
            //Imprimir por consola
            Debug.Log(i); 
        }
    }
}
