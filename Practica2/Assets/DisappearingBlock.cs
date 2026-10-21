using UnityEngine;

public class DisappearingBlock : MonoBehaviour
{
    private bool jugadorEncima = false; // Indica si el jugador está sobre el bloque
    void Update()
    {
        if (jugadorEncima)
        {
            Destroy(gameObject, 3f); // El objeto se destruirá en 3 segundos
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            jugadorEncima = true;
        }
    }
}
