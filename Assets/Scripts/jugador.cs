using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class jugador : MonoBehaviour
{
    public float velocidad = 3f;
    private float movimientoX;

    public float fuerzaSalto = 4f;
    private bool enSuelo = false;
    private Rigidbody2D rb;

    public AudioSource audioSource;
    public AudioClip getcoin;
    void OnMove(InputValue input)
    {
        movimientoX = input.Get<Vector2>().x;
        if (movimientoX > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (movimientoX < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    void Update()
    {
        transform.Translate(movimientoX * velocidad * Time.deltaTime, 0, 0);
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnJump(InputValue input)
    {
        if (enSuelo == true)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, fuerzaSalto);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            enSuelo = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            enSuelo = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("moneda")) {
            audioSource.PlayOneShot(getcoin);
            FindAnyObjectByType<GameManager>().sumarPuntos();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("enemigo")){
            FindAnyObjectByType<GameManager>().restarVida();
        }
    }
}
