using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    //Declaramos los 3 números, en este caso privados, los serializamos para poder modificarlos desde el inspector.
    [SerializeField]
    private int _numberOne;
    [SerializeField]
    private int _numberTwo;
    [SerializeField]
    private int _numberThree;
  
    void Start()
    {  
        
        
        //Llamarlo desde el "Start".
        IsAscendingNumber(); 
    }

   

private void IsAscendingNumber()
    {



        // Comprobamos primero si los 3 números son iguales
        if (_numberOne == _numberTwo && _numberTwo == _numberThree)
        {



            Debug.Log("Los tres números son iguales.");
        }



        // Si no son iguales comprobamos todas las combinaciones posibles.
        //El 1 es menor o igual al 2 y el 2 menor o igual al 3.
        else if (_numberOne <= _numberTwo && _numberTwo <= _numberThree)
        {



            Debug.Log("El orden ascendente de los números es:\t" + _numberOne + "\t" + _numberTwo + "\t" + _numberThree);
        }


        //El 2 menor o igual al 3 y el 3 menor o igual al 1.
        else if (_numberOne <= _numberThree && _numberThree <= _numberTwo)
        {



            Debug.Log("El orden ascendente de los números es:\t" + _numberOne + "\t" + _numberThree + "\t" + _numberTwo);
        }


        //Si el 2 es menor o igual al 1 y el uno menor o igual al 3.
        else if (_numberTwo <= _numberOne && _numberOne <= _numberThree)
        {



            Debug.Log("El orden ascendente de los números es:\t" + _numberTwo + "\t" + _numberOne + "\t" + _numberThree);
        }


        //Si el 2 es menor o igual al 3 y el 3 menor o igual al 1.
        else if (_numberTwo <= _numberThree && _numberThree <= _numberOne)
        {



            Debug.Log("El orden ascendente de los números es:\t" + _numberTwo + "\t" + _numberThree + "\t" + _numberOne);
        }


        //Si el 3 es menor o igual al 1 y el 1 menor o igual al 2.
        else if (_numberThree <= _numberOne && _numberOne <= _numberTwo)
        {



            Debug.Log("El orden ascendente de los números es:\t" + _numberThree + "\t" + _numberOne + "\t" + _numberTwo);
        }
        else
        {



            // Última combinación posible.
            Debug.Log("El orden ascendente de los números es:\t" + _numberThree + "\t" + _numberTwo + "\t" + _numberOne);
        }
    }

}
