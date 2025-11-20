using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] PERSONAJECONTROL PERSONAJECONTROL;
    [SerializeField] GameObject imagenPerder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (PERSONAJECONTROL.vida <= 0)
    //    {
    //        imagenPerder.SetActive(true);
    //        StartCoroutine(CargarCreditos());
    //    }
    //}
}
