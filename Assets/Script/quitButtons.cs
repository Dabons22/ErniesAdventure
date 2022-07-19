using UnityEngine.SceneManagement;
using UnityEngine;

public class quitButtons : MonoBehaviour
{
    public void QUITGAME() {
        Application.Quit();

    }
    public void Startgame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void aboutGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void PrevScrene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
}
