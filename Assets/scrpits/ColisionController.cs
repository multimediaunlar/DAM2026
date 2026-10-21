using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionController : MonoBehaviour
{
    public GameController gameController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Heroo"))
        {
            GameOver();
        }
    }

    void GameOver()
    {
        // Lógica para el Game Over
    }

    void MissionCompleted()
    {
        // Lógica para cuando la misión se completa
    }
}
