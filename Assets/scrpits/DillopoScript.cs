using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DillopoScript : MonoBehaviour
{
    // Referencia al prefab del proyectil
    public GameObject BulletPrefab;
    
    // Referencia al objeto del héroe
    public GameObject Hero;

    // Último momento en que se disparó
    private float LastShoot;

    // Salud del Dillopo
    private int Health = 3;

    // Método que se llama en cada frame
    private void Update()
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
                Shoot();
                LastShoot = Time.time;
        }
    }

    // Método para disparar
    private void Shoot()
    {
        // Determina la dirección del disparo
        Vector3 direction;
        if(transform.localScale.x == 1.0f) 
            direction = Vector3.right;
        else 
            direction = Vector2.left;

        // Instancia el proyectil
        GameObject bullet = Instantiate(BulletPrefab, transform.position + direction * 0.1f, Quaternion.identity);

        // Configura la dirección del proyectil
        bullet.GetComponent<BulletOrangeScript>().SetDirection(direction);
    }

    // Método llamado cuando el Dillopo es golpeado
    public void Hit()
    {
        // Decrementa la salud
        Health = Health - 1;

        // Muestra un mensaje en la consola indicando que el Dillopo fue golpeado y su salud actual
        Debug.Log("Dillopo golpeado! Salud: " + Health);

        // Destruye el objeto del Dillopo si su salud llega a cero
        if (Health == 0) 
            Destroy(gameObject);
    }
}
