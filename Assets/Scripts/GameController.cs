using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool IsGameOver { get; private set; }

    private void OnEnable()
    {
        EndPoint.EndPointChange += GameOver;
    }

    private void OnDisable()
    {
        EndPoint.EndPointChange -= GameOver;
    }

    private void GameOver()
    {
        IsGameOver = true;
        SceneManager.LoadScene("GameOver");
    }
}
