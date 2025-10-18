using UnityEngine;

public class RandomNumber : MonoBehaviour
{


    
  
    void Start()
    {

        ShowPrediction();
        
    }
    private void ShowPrediction()
    {
        // Definimos un array de 5 mensajes inventados sobre predicciones de futuro.
        string[] predictions = new string[5]
        {
            "Hoy hará sol",
            "Tendrás mucho dinero",
            "Tendrás un día interesante",
            "Mañana verás una película",
            "Recibirás buenas noticias pronto"
        };

        // Generamos un número aleatorio entre 0 y 4
        int randomIndex = Random.Range(0, predictions.Length);

        // Imprimimos en consola el mensaje seleccionado aleatoriamente
        Debug.Log(predictions[randomIndex]);
    }
}

   

