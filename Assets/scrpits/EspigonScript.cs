using UnityEngine;

public class EspigonScript : MonoBehaviour
{
    public float walkingSpeed = 2.0f; // Velocidad de caminata del personaje

    private float startX; // Posición inicial en X
    private float distanceWalked; // Distancia recorrida desde el punto inicial
    private bool movingRight = true; // Indica si el personaje se está moviendo hacia la derecha

    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x; // Almacenar la posición inicial en X
    }

    // Update is called once per frame
    void Update()
    {
        // Mover el personaje horizontalmente
        if (movingRight)
        {
            // Mover hacia la derecha
            transform.Translate(Vector3.right * walkingSpeed * Time.deltaTime);
            distanceWalked = transform.position.x - startX; // Calcular la distancia recorrida desde el inicio

            // Si ha caminado más de 5 metros, cambiar dirección
            if (distanceWalked >= 30.0f)
                movingRight = false;

            // Voltear hacia la derecha
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            // Mover hacia la izquierda
            transform.Translate(Vector3.left * walkingSpeed * Time.deltaTime);
            distanceWalked = transform.position.x - startX; // Calcular la distancia recorrida desde el inicio

            // Si ha vuelto a la posición inicial, cambiar dirección
            if (distanceWalked <= 0.0f)
                movingRight = true;

            // Voltear hacia la izquierda
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    // Método para manejar colisiones físicas
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.PerderVida();
                        // Imprimir mensaje en la consola
            Debug.Log("El jugador ha colisionado con el objeto espigón. Game Over!");
        }
    }

}

