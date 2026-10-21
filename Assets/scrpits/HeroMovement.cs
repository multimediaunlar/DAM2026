using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroMovement : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float Speed;
    public float JumpForce;
    
    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private float Horizontal;
    private bool Grounded;
    private float LastShoot;
    private int Health = 5;

    Vector3 InitPosition;

public Vector3 respawnPosition;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();

        InitPosition = this.transform.position;


    }

    void Update()
    {   
        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3 (1.0f, 1.0f, 1.0f);

        Animator.SetBool("Running", Horizontal != 0.0f);

        Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);
        if (Physics2D.Raycast(transform.position, Vector3.down, 2.0f))
        {
            Grounded = true;
        }
        else
        {
            Grounded = false;
        }

        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        {
            Jump();
        }

        if (Input.GetKey(KeyCode.Space) && Time.time > LastShoot + 0.25f)
        {
            Shoot();
            LastShoot = Time.time;
        }
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }

    private void Shoot()
    {
        Vector3 direction = transform.localScale.x == 1.0f ? Vector3.right : Vector3.left;

        GameObject bullet = Instantiate(BulletPrefab, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<BulletOrangeScript>().SetDirection(direction);

        // Ignorar colisión entre el personaje y la bala recién creada
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), bullet.GetComponent<Collider2D>());
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal * Speed, Rigidbody2D.velocity.y);
    }

    public void Hit()
    {
        Health--;
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }


    // Método llamado cuando otro objeto entra en el área del trigger
    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el jugador ha colisionado con el trigger de reinicio
        if (other.CompareTag("RespawnTrigger"))
        {
            // Reiniciar la posición del jugador
            Respawn();
        }
    }

    // Método para reiniciar la posición del jugador
    void Respawn()
    {
        // Mover al jugador a la posición de reinicio
        transform.position = respawnPosition;
        
        // Restaurar cualquier otra configuración necesaria (velocidad, estado, etc.)
    }

    public void ResetPosition()
    {
        this.transform.position = InitPosition;
    }
    
}