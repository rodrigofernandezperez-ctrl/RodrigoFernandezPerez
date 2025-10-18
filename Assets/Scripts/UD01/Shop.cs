using System.Buffers;
using UnityEngine;

public class Shop : MonoBehaviour
{
    //Las variables brécol y patatas.
    [SerializeField]
    private int _potatoes;
    [SerializeField]
    private int _broccoli;

    //Cantidad que el usuario quiere añadir o restar
    [SerializeField]
    private int _amountToAdd;
    [SerializeField]
    private int _amountToSubtract;
    





    void Start()
    {


        Operations();
    }


    private void Operations()
    {


        // Llamamos a los métodos usando los valores introducidos por el usuario.
        _potatoes = AddProduct(_potatoes, _amountToAdd);
        _broccoli = SubtractProduct(_broccoli, _amountToSubtract);


        // Mostramos el resultado final
        Debug.Log("Unidades finales de patatas: " + _potatoes);
        Debug.Log("Unidades finales de brécol: " + _broccoli);
    }

    // Método que añade unidades y devuelve el nuevo valor.
    private int AddProduct(int product, int amount)
    {
        return product + amount;
    }

    // Método que resta unidades y devuelve el nuevo valor.
    private int SubtractProduct(int product, int amount)
    {
        if (amount > product)
        {
            return 0;
        }
        else
        {
            return product - amount;
        }
    }


}

    

