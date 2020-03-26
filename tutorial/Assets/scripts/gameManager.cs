using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public bool gameover = false;

    public float restartDelay = 3f;

    public GameObject completeLevelUI;
    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("Level 1");
    }

    public void EndGame()
    {
        if( gameover == false )
        {
            Debug.Log("GAME OVER!");
            gameover = true;
            Invoke("restart", restartDelay);
        }
    }

    void restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
