using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float velocidadVertical = 5f; // Velocidad del movimiento vertical
    public float velocidadHorizontal = 250f; // Velocidad del movimiento horizontal
    public float fuerzaSalto = 5f; // Fuerza del salto
    private Rigidbody rb; // Referencia al Rigidbody

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtener el componente Rigidbody
    }

    void Update()
    {
        // Movimiento hacia adelante y atrás
        float moverAdelanteAtras = Input.GetAxis("Vertical") * velocidadVertical *
        Time.deltaTime;
        transform.Translate(0, 0, moverAdelanteAtras);

        // Rotación izquierda y derecha
        float rotarIzquierdaDerecha = Input.GetAxis("Horizontal") *
        velocidadHorizontal * Time.deltaTime;
        transform.Rotate(0, rotarIzquierdaDerecha, 0);

        // Saltar
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.linearVelocity.y) <
        0.01f)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }
}
