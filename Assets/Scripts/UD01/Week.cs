using UnityEngine;

public class Week : MonoBehaviour
{

    //Zona de variables globales.

    public int MonthNumber;
    void Start()
    {
        //Llamarlo en el start.
        IsNumberMonth();
    }

   private void IsNumberMonth()
    {

        switch (MonthNumber)
        {

            case 1:
                Debug.Log("January");
                break;
            case 2:
                Debug.Log("February");
                break;
            case 3:
                Debug.Log("March");
                break;
            case 4:
                Debug.Log("April");
                break;
            case 5:
                Debug.Log("May");
                break;
            case 6:
                Debug.Log("June");
                break;
            case 7:
                Debug.Log("July");
                break;

                //Si se introduce un número no correspondiente a los específicados:
            default:
                Debug.Log("El número introducido no es válido");
                break;

        }
    }
}
