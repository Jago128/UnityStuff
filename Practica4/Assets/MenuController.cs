using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void IniciarJuego()
    {
        // Cargar la escena principal del juego
        SceneManager.LoadScene("GameScene");
    }
}
