using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Hero;

    // Update is called once per frame
    void Update()
    {
        if (Hero != null) // Verifica si el GameObject Hero no es nulo
        {
            Vector3 position = transform.position;
            position.x = Hero.transform.position.x;
            transform.position = position;
        }
    }
}
