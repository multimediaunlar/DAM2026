using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public HUD hud;
    private int vidas = 3;

    public event EventHandler MuerteJugador;

    // Referencia al GameObject del jugador
    public GameObject jugador;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else 
        {
            Debug.Log("¡Cuidado! ¡Más de un GameManager en escena!");
        }
    }

    public void PerderVida()
    {
        vidas -= 1;
        hud.DesactivarVida(vidas);

        if (vidas <= 0)
        {
            // Si el jugador se queda sin vidas, destruir el GameObject del jugador
            if (jugador != null)
            {
                Debug.Log("Matando jugador GAME OVER!!!");
                MuerteJugador?.Invoke(this, EventArgs.Empty);
                Destroy(jugador);
            }

            // Aquí puedes agregar más lógica, como mostrar una pantalla de game over o reiniciar el nivel
        }
    }
}
