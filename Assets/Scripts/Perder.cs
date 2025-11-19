using UnityEngine;
using UnityEngine.SceneManagement;

public class Perder : MonoBehaviour
{
    public void Reiniciar() {
        SceneManager.LoadScene("nivel1");
    }
    public void salir() {
        Debug.Log("saliendo ...");
        Application.Quit();
    }
}
