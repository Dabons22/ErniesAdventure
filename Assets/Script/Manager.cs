using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager : MonoBehaviour
{
    bool hasEnded = false;
    public float restartDeslay = 1f;
    public GameObject LevelCompleteUI;
    public void Endgame()
    {

        if (hasEnded == false)
        {
            hasEnded = true;
            Invoke("Restart", restartDeslay);

        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel() {
        LevelCompleteUI.SetActive(true);
    }
}
