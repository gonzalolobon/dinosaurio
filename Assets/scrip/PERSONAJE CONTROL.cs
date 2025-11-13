using UnityEngine;
using UnityEngine.InputSystem;

public class PERSONAJECONTROL : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;
    [SerializeField] float saltoAltura;
    [SerializeField] private GameObject WEA;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void salto(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            animator.SetBool("SALTAR", true);
            rb.linearVelocity = Vector2.zero;
            rb.AddForce(Vector2.up * saltoAltura);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "SUELO")
        {
            animator.SetBool("SALTAR", false);
        }
        if (collision.transform.tag == "enemigo")
        {
            WEA.SetActive(false);
        }
    }
}
