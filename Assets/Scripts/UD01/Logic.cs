using UnityEngine;

public class Logic : MonoBehaviour
{
    
    void Start()
    {


        LogicNumber();
    }
    private void LogicNumber()
    {

        //.Definimos un array de 3 valores lógicos inicializados a false
        bool[] cell = new bool[3];
        cell[0] = false;
        cell[1] = false;
        cell[2] = false;


        // 2. Marcamos como verdadero el valor de la primera posición
        cell[0] = true;


        // 3. Imprimimos en consola el valor de cada casilla
        for (int i = 0; i < cell.Length; i++)
        {
            Debug.Log( + i + ": " + cell[i]);
        }



    }

}
