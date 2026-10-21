using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel : MonoBehaviour
{
    // Start se llama antes del primer frame
    void Start()
    {
        
    }

    // Update se llama una vez por frame
    void Update()
    {
        
    }

    [ContextMenu("Boton Cambiar Nivel")]
    public void CambiarNivel()
    {
        int nivelAtual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(nivelAtual + 1);
    }

    // Esta función se llama automáticamente cuando hay una colisión en 2D
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Tocando algo");

        // Verifica si el objeto con el que colisionaste tiene la etiqueta "Cambio"
        if (collision.gameObject.tag == "Cambio")
        {
            Debug.Log("Tocando algo con la etiqueta Cambio");
            int nivelAtual = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(nivelAtual + 1);
        }
    }
}
