using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimetrodomScript : MonoBehaviour
{
    public GameObject Hero; // Se debe declarar la variable Hero
    public float walkingSpeed = 2.0f; // Velocidad de caminata del personaje

    private float startX; // Posición inicial en X
    private float distanceWalked; // Distancia recorrida desde el punto inicial
    private bool movingRight = true; // Indica si el personaje se está moviendo hacia la derecha
    private float LastShoot; // Variable para controlar el tiempo entre disparos

    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x; // Almacenar la posición inicial en X
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica si el héroe no es nulo
        if (Hero != null)
        {
            // Calcula la dirección hacia el héroe
            Vector3 direction = Hero.transform.position - transform.position;

            // Voltea la escala del objeto según la dirección del héroe
            if (direction.x >= 0.0f) 
                transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            else 
                transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

            // Calcula la distancia al héroe
            float distance = Mathf.Abs(Hero.transform.position.x - transform.position.x);

            // Revisión para disparar basada en distancia y tiempo
            if (distance < 7.0f && Time.time > LastShoot + 0.25f)
            {
                Shoot();
                LastShoot = Time.time;
            }
        }

        // Mover el personaje horizontalmente
        if (movingRight)
        {
            // Mover hacia la derecha
            transform.Translate(Vector3.right * walkingSpeed * Time.deltaTime);
            distanceWalked = transform.position.x - startX; // Calcular la distancia recorrida desde el inicio

            // Si ha caminado más de 2 metros, cambiar dirección
            if (distanceWalked >= 10.0f)
                movingRight = false;
        }
        else
        {
            // Mover hacia la izquierda
            transform.Translate(Vector3.left * walkingSpeed * Time.deltaTime);
            distanceWalked = transform.position.x - startX; // Calcular la distancia recorrida desde el inicio

            // Si ha vuelto a la posición inicial, cambiar dirección
            if (distanceWalked <= 0.0f)
                movingRight = true;
        }
    }

    private void Shoot()
    {
        // Este método debería definirse para que la clase funcione correctamente
        //Debug.Log("Disparar!");
    }

        private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.PerderVida();
        }
    }
}
