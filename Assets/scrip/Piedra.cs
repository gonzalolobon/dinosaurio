using UnityEngine;

public class Enemigo_Cactus : MonoBehaviour
{
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionInicial;
    [SerializeField] Vector2 posicionMinima;

    [SerializeField] float velocidadBase = 6f;
    [SerializeField] float velocidadActual;
    [SerializeField] float incrementoVelocidad = 0.2f;
    [SerializeField] float tiempoIncremento = 3f;
    float temporizadorVelocidad;

    [SerializeField] GameObject cactusOriginal;

    public float escalaPeque = 0.7f;
    public float escalaNormal = 1f;
    public float escalaGrande = 1.3f;

    public float separacion = 0.7f;

    void Start()
    {
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(Vector2.zero);
        posicionInicial = transform.position;

        velocidadActual = velocidadBase;
        GenerarCactusAleatorio();
    }

    void Update()
    {
        transform.Translate(Vector2.left * velocidadActual * Time.deltaTime);

        if (transform.position.x < posicionMinima.x)
        {
            transform.position = posicionInicial;
            GenerarCactusAleatorio();
        }

        temporizadorVelocidad += Time.deltaTime;
        if (temporizadorVelocidad >= tiempoIncremento)
        {
            velocidadActual += incrementoVelocidad;
            temporizadorVelocidad = 0f;
        }
    }

    void GenerarCactusAleatorio()
    {
        foreach (Transform hijo in transform)
            Destroy(hijo.gameObject);

        int tipo = Random.Range(1, 5);

        float escalaElegida = escalaNormal;
        int cantidad = 1;

        if (tipo == 1)
        {
            cantidad = 1;
            escalaElegida = escalaNormal;
        }
        else if (tipo == 2)
        {
            cantidad = Random.Range(2, 4);
            escalaElegida = escalaNormal;
        }
        else if (tipo == 3) 
        {
            cantidad = 1;
            escalaElegida = escalaGrande;
        }
        else if (tipo == 4) 
        {
            cantidad = Random.Range(2, 4);
            escalaElegida = escalaPeque;
        }

        CrearCactus(cantidad, escalaElegida);
    }

    void CrearCactus(int cantidad, float escala)
    {
        for (int i = 0; i < cantidad; i++)
        {
            GameObject nuevo = Instantiate(cactusOriginal, transform);

            nuevo.transform.localPosition = new Vector2(i * separacion, 0);

            nuevo.transform.localScale = new Vector3(escala, escala, 1);

            BoxCollider2D col = nuevo.GetComponent<BoxCollider2D>();
            if (col != null)
            {
                float altura = col.size.y * escala;
                nuevo.transform.localPosition = new Vector2(i * separacion, -altura / 2f);
            }
        }
    }
}
