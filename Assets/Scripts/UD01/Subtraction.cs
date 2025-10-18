using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Subtraction : MonoBehaviour
{
    [SerializeField]
    private int _number; 


    void Start()
    {
        GetSubstraction(_number);
        
    }

    //Método 
    private void GetSubstraction(int number)
    {
        // Comprobamos que el número sea mayor que 1
        if (_number <= 1)
        {
            Debug.Log("Introduce un número mayor que 1.");
            return;
        }

        // Bucle que empieza desde el número que el usuario introduce - 1 y va hasta 1 restando de uno en uno
        for (int i = _number - 1; i >= 1; i--)
        {
            Debug.Log(i);
        }


    }
}


