using UnityEngine;

public class Number : MonoBehaviour
{

    [SerializeField]
    private int _number;
    
    void Start()
    {
        //Llamarlo desde el "Start".
        IncrementNumber(_number);
    }

    //Método que recibe un número
    private int IncrementNumber(int number)
    {
        //Se incrementa en 1.
        int result = number + 1;
        Debug.Log("El número incrementado es: " + result);
        
        
        //devolvemos el valor
        return result;

    }
}
