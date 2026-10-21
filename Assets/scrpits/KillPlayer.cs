using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    HeroMovement pm;
    private void Start()
    {
        pm = FindObjectOfType<HeroMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pm.ResetPosition();       
        }
    }
}
