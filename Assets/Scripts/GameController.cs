using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void GameOver()
    {
        SceneManager.LoadScene(1);
    }
}