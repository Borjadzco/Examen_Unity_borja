using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text textoPuntos;
    private int puntos;
    private int puntosTotales;
    void Start()
    {
        puntos = 0;
        puntosTotales = 10;
        textoPuntos.text = "0";
    }

    public void sumarPuntos() {
        puntos++;
        if (puntos >= puntosTotales) { 
            
        }
    
    }
}
