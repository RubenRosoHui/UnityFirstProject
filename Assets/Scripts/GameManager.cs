using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float Delay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        Debug.Log("End Level");
        completeLevelUI.SetActive(true);
    }

    public void EndGame() 
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", Delay);
            
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
