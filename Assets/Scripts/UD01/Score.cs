using UnityEngine;

public class Score : MonoBehaviour
{
 [SerializeField]
 private int _score;

    void Start()
    {

        //Llamamos al método con la puntuación
        CheckScore(_score);
    }

    //Método que recibe la puntuación y comprueba si ha llegado a 45.
    private void CheckScore(int score)
    {

        //Si ha llegado a 45.
        if (score >= 45)
        {

            Debug.Log("¡Has llegado a 45!");
        }
        else
        {

            //Si no ha llegado a 45.
            Debug.Log("No has llegado a 45");
        }

    }

  
}
