using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    [SerializeField]
    private int _numberOne;
    [SerializeField]
    private int _numberTwo;
    [SerializeField]
    private int _numberThree;

    void Start()
    {
        IsInDescendingOrder();
    }

    private void IsInDescendingOrder()
    {

        //Comprobación de que los números están en orden drecreciente.
        if (_numberOne >= _numberTwo && _numberTwo >= _numberThree)
        {

            //Impresión en consola si se cumple esto.
            Debug.Log("Los números están en orden decreciente");
        }
        else
        {

            //Impresión en consola para todo lo demás.
            Debug.Log("Los números no están en orden decreciente");
        }



    }
}
