using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAMEOVER : MonoBehaviour
{
    [SerializeField] PERSONAJECONTROL PERSONAJECONTROL;
    [SerializeField] GameObject imagenPerder;
    [SerializeField] GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PERSONAJECONTROL.vida <= 0)
        {
            imagenPerder.SetActive(true);
            StartCoroutine(CargarCreditos());
        }
    }

    IEnumerator CargarCreditos()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("CREDITOS");
    }
}
