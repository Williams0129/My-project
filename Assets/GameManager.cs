using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    public float restartDelay = 1f;
    public void EndGame()
    {
        if (GameHasEnded == false) 
        {
            GameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", restartDelay);//等一下再呼叫
        }
    }

    void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//SceneManager.GetActiveScene().name會回傳目前的scene的名字，SceneManager.LoadScene()會載入該scene
    }
}
