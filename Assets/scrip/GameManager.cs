using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] PERSONAJECONTROL PERSONAJECONTROL;
    [SerializeField] GameObject imagenPerder;
    [SerializeField] GameObject enemigo2;
    [SerializeField] int vida;
    [SerializeField] enemigo2 enemigo2scrip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void ReiniciarJuego()
    {
        imagenPerder.SetActive(false);



        // Activar nuevamente el enemigo
        enemigo2.SetActive(true);
        enemigo2scrip.EnemigoReiniciar();
    }
    }
