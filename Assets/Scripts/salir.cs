using UnityEngine;
using UnityEngine.SceneManagement;

public class salir : MonoBehaviour
{
    public void Salir() {
        Debug.Log("saliendo ...");
        Application.Quit();
    }
}
