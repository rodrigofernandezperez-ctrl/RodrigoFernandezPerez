using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    private int _number;
    void Start()
    {


        GetNumberMultiplesOfThreeTwo();
    }


    private void GetNumberMultiplesOfThreeTwo()
    {


        //Mostramos los múltiplos de 3 y de 2 entre 0 y 100.
        for ( int i = 0; i <= 101; i++)
        {

            //Utilizamos el % para saber el resto.
            if (i % 3 ==0 || i % 2 == 0)
            {


                Debug.Log(i);

            }
        }


    }
  
}
