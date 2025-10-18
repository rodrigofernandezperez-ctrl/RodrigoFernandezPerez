using UnityEngine;

public class FromLargestToSmallets : MonoBehaviour
{
    [SerializeField]
    private int _numberOne;
    [SerializeField]
    private int _numberTwo;
    [SerializeField]
    private int _numberThree;



    void Start()
    {
        IsDescendingNumber();
    }



    private void IsDescendingNumber()
    {


        // Comprobamos primero si los 3 números son iguales.
        if (_numberOne == _numberTwo && _numberTwo == _numberThree)
        {



            Debug.Log("Los tres números son iguales.");
        }

        
        //Comprobamos todas las combinaciones posibles.
        // El 1 es mayor o igual al 2 y el 2 mayor o igual al 3.
        else if (_numberOne >= _numberTwo && _numberTwo >= _numberThree)
        {


            Debug.Log("El orden descendente de los números es:\t" + _numberOne + "\t" + _numberTwo + "\t" + _numberThree);
        }

        //El 1 es mayor o igual al 3 y el 3 mayor o igual al 2.
        else if (_numberOne >= _numberThree && _numberThree >= _numberTwo)
        {



            Debug.Log("El orden descendente de los números es:\t" + _numberOne + "\t" + _numberThree + "\t" + _numberTwo);
        }

        // El 2 mayor o igual al 1 y el 1 mayor o igual al 3.
        else if (_numberTwo >= _numberOne && _numberOne >= _numberThree)
        {
            Debug.Log("El orden descendente de los números es:\t" + _numberTwo + "\t" + _numberOne + "\t" + _numberThree);
        }

        // El 2 mayor o igual al 3 y el 3 mayor o igual al 1.
        else if (_numberTwo >= _numberThree && _numberThree >= _numberOne)
        {
            Debug.Log("El orden descendente de los números es:\t" + _numberTwo + "\t" + _numberThree + "\t" + _numberOne);
        }

        // El 3 mayor o igual al 1 y el 1 mayor o igual al 2.
        else if (_numberThree >= _numberOne && _numberOne >= _numberTwo)
        {
            Debug.Log("El orden descendente de los números es:\t" + _numberThree + "\t" + _numberOne + "\t" + _numberTwo);
        }

        // Última combinación posible.
        else
        {
            Debug.Log("El orden descendente de los números es:\t" + _numberThree + "\t" + _numberTwo + "\t" + _numberOne);
        }


    }

 
}
