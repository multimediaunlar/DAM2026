using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugadorScript : MonoBehaviour
{
    public int cantidadDeVida;

    public void TomarDaño(int daño)
    {
        cantidadDeVida -= daño;
        if(cantidadDeVida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
