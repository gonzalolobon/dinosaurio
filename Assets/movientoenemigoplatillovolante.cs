using UnityEngine;

public class enemigo2 : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posiciionMinima;
    [SerializeField] Vector2 posicionInicial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicionInicial = transform.position;
        camara = Camera.main;
        posiciionMinima = camara.ViewportToWorldPoint(Vector2.zero);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * velocidad * Time.deltaTime);
        if (transform.position.y < posiciionMinima.y)
        {
            //Destroy(gameObject, 1f);

            transform.position = posicionInicial;
            velocidad++; 
           
        }
    }
}
