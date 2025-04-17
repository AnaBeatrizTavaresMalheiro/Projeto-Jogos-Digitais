using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    void Start() {
        
    }

    void Update() {
        
    }

    public void Play() {
        SceneManager.LoadScene("Pre Historia");
    }

    public void Quit() {
        Application.Quit();
    }

}
