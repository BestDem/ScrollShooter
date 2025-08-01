using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class RestartTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent restartAfterDeath;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            restartAfterDeath?.Invoke();
        }
    }

    public void OnButtonRestart()
    {
        restartAfterDeath?.Invoke();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadSceneIndex(int level)
    {
        SceneManager.LoadScene(level);
    }
    
    public void OnButtonExit()
    {
        Application.Quit();
    }
}
