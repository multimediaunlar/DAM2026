using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MenuGameOver : MonoBehaviour
{
    [SerializeField] private GameObject menuGameObject; // Cambiado el nombre de la variable a 'menuGameObject'

    private GameManager combateJugador;

    private void Start()
    {
        combateJugador = GameObject.FindGameObjectWithTag("Player").GetComponent<GameManager>();
        GameManager.Instance.MuerteJugador += ActivarMenu;
    }

    private void ActivarMenu(object sender, EventArgs e)
    {
        menuGameObject.SetActive(true); // Cambiado 'MenuGameOver' a 'menuGameObject'
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuInicial(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

public void Salir()
{
    Application.Quit();
}


}
