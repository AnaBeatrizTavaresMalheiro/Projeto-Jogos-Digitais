using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    void Start() {
        MusicManager.Instance.PlayMusic("MainMenu"); // toca a musica do menu
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) { // Botão esquerdo do mouse
            SoundManager.Instance.PlaySound2D("MouseClick");
        }
    }

    public void Play() { // quando clicar no botao de Play:
        SceneManager.LoadScene("Pre Historia"); // troca de cena
        MusicManager.Instance.StopMusic(); // para de tocar a musica
    }

    public void Quit() { // quando clicar no botao de Quit:
        Application.Quit();
    }

}
