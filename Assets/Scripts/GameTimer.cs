using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private Text textTimer;
    private float timer = 0;
    private bool isplaying = true;

    private void Update()
    {
        if (isplaying)
            timer += Time.deltaTime;
    }

    public void GetTimeSpent()
    {
        int time = Mathf.RoundToInt(timer / 60f);
        textTimer.text = time.ToString();
        isplaying = false;
    }

    public void RestartTimer()
    {
        timer = 0;
        isplaying = true;
    }
}
