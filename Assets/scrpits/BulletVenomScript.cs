using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletVenomScript : MonoBehaviour
{
    public float velocidad;
    public int daño;

    private void Update()
    {
        transform.Translate(Time.deltaTime * velocidad * Vector2.right);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.PerderVida();
        }
    }
    


}
