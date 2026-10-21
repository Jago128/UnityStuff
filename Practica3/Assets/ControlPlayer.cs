using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float velocidadVertical = 5f; // Velocidad del movimiento vertical
    public float velocidadHorizontal = 250f; // Velocidad del movimiento horizontal
    public float fuerzaSalto = 5f; // Fuerza del salto
    private Rigidbody rb; // Referencia al Rigidbody
    private Animator animator; // Referencia al Animator

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtener el componente Rigidbody
        animator = GetComponent<Animator>(); // Obtener el componente Animator
    }

    void Update()
    {
        // Movimiento hacia adelante y atrás
        float moverAdelanteAtras = Input.GetAxis("Vertical") * velocidadVertical *
        Time.deltaTime;
        transform.Translate(0, 0, moverAdelanteAtras);

        if (moverAdelanteAtras > 0)
        {
            animator.SetBool("isWalking", true); //se está moviendo
        }
        else
        {
            animator.SetBool("isWalking", false); //está parado
        }


        // Rotación izquierda y derecha
        float rotarIzquierdaDerecha = Input.GetAxis("Horizontal") *
        velocidadHorizontal * Time.deltaTime;
        transform.Rotate(0, rotarIzquierdaDerecha, 0);

        // Saltar
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.linearVelocity.y) <
        0.01f)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            animator.SetBool("isJumping", true); //está saltando
        }
        else
        {
            animator.SetBool("isJumping", false); //termina el salto
        }
    }
}
