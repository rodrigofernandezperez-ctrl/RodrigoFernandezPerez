using UnityEngine;

public class Change : MonoBehaviour
{
   
    void Start()
    {


        ChangeNumber();
        
    }

    private void ChangeNumber()
    {
        //Definimos un array de 5 números enteros todos con el número 1.
        int[] numbers = new int[5] { 1, 1, 1, 1, 1 };



        //Cambiamos el valor de la primera y última posición a 42.
        numbers[0] = 42;
        numbers[4] = 42;


        //Imprimimos el valor de cada posición.
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(i + ": " + numbers[i]);
        }


    }

 
}
