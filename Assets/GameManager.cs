using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    bool gameHaseEnded = false;
    public float restartDelay = 2f;

    public void EndGame()
    {
        if(gameHaseEnded == false)
        {
            gameHaseEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
