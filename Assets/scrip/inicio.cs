using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class inicio : MonoBehaviour
{
    public void Jugar()

    {
        SceneManager.LoadScene("SampleScene");

    }
    public void Salir()
    {
        Application.Quit();
    }
   
}
