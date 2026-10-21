using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOrangeScript : MonoBehaviour
{
    public AudioClip Sound; 

    public float Speed;
    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;
    private GameObject owner; // Almacena una referencia al enemigo que disparó la bala

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Sound);
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Direction * Speed;
    }

    // Establece la dirección de movimiento de la bala
    public void SetDirection(Vector2 direction)
    {
        Direction = direction;
    }

    // Establece el dueño de la bala (el enemigo que la disparó)
    public void SetOwner(GameObject ownerGameObject)
    {
        owner = ownerGameObject;
    }

    // Destruye la bala
    public void DestroyBullet()
    {
        Destroy(gameObject);
    }

    // Se llama cuando la bala entra en contacto con otro collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el collider con el que colisionó es el jugador o el enemigo
        HeroMovement hero = other.GetComponent<HeroMovement>();
        DillopoScript dillopo = other.GetComponent<DillopoScript>();
        PachyScript pachy = other.GetComponent<PachyScript>();
        
        // Si es el jugador, llama al método Hit() del jugador
        if (hero != null)
        {
            hero.Hit();
        }

        // Si es el enemigo, llama al método Hit() del enemigo
        if (dillopo != null)
        {
            dillopo.Hit();
        }

        // Destruye la bala después de causar daño
        DestroyBullet();



        // Si es el enemigo, llama al método Hit() del enemigo
        if (pachy != null)
        {
            pachy.Hit();
        }

        // Destruye la bala después de causar daño
        DestroyBullet();
    }
}
