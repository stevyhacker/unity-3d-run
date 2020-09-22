using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtnScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}