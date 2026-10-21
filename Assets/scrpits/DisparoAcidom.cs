using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoAcidom : MonoBehaviour
{
    public Transform controladorDisparo;
    public float distanciaLinea;
    public LayerMask capaJugador;
    public bool jugadorEnRango;
    public GameObject balaEnemigo;
    public float tiempoEntreDisparos;
    public float TiempoUltimoDisparo;
    public float tiempoEsperaDisparo;

    private void Update()
    {
        jugadorEnRango = Physics2D.Raycast(controladorDisparo.position, -transform.right, distanciaLinea, capaJugador);

        if (jugadorEnRango)
        {
            if(Time.time > tiempoEntreDisparos + TiempoUltimoDisparo)
            {
                TiempoUltimoDisparo = Time.time;
                Invoke(nameof(Disparar), tiempoEsperaDisparo);
            }
            // Coloca aquí la lógica para lo que quieres hacer cuando el jugador esté en rango
        }
    }

    private void Disparar()
    {
        Instantiate(balaEnemigo, controladorDisparo.position, controladorDisparo.rotation);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(controladorDisparo.position, controladorDisparo.position - transform.right * distanciaLinea);
    }
}
