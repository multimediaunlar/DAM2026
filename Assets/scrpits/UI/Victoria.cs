using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoria : MonoBehaviour
{
    public GameObject victoryUI;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            // Activar la interfaz de usuario de victoria
            victoryUI.SetActive(true);
        }
    }
}
