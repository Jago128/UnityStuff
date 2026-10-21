using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int puntos = 10;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            // Buscar el controlador de puntuación y sumar puntos
            ScoreController controlador = FindObjectOfType<ScoreController>();
            if (controlador != null)
            {
                controlador.IncrementarPuntuacion(puntos);
            }
            // Destruir el objeto coleccionable
            Destroy(gameObject);
        }
    }
}
