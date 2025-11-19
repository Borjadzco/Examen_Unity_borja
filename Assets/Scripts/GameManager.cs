using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text textoPuntos;
    public TMP_Text textoVida;
    private int vida;
    private int puntos;
    private int puntosTotales;
    void Start()
    {
        puntos = 0;
        vida = 2;
        puntosTotales = 10;
        textoPuntos.text = puntos + "/" + puntosTotales;
        textoVida.text = "2" + "/" + vida;
    }

    public void sumarPuntos()
    {
        puntos++;

        textoPuntos.text = puntos + "/" + "10";

    }
    public void restarVida() {
        vida--;
        textoVida.text = vida + "/" + "2";
        if (vida <= 0) {
            SceneManager.LoadScene("Perder");
        }
    }
}
