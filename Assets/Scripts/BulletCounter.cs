using UnityEngine;
using UnityEngine.UI;

public class BulletCounter : MonoBehaviour
{
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private Text countBulletText;
    [SerializeField] private Text maxBulletText;
    [SerializeField] private float maxBullet;
    [SerializeField] private float timeRestart;
    private float currentBullet;
    private float timer = 0;
    private bool canShootPlayer = true;
    public bool CanShootPlayer => canShootPlayer;
    public float CurrentBullet => currentBullet;

    private void Start()
    {
        currentBullet = maxBullet;
        countBulletText.text = currentBullet.ToString();
        maxBulletText.text = currentBullet.ToString();
    }
    private void Update()
    {
        if (currentBullet < maxBullet)
            RestartBullet();
    }

    public void AttackBullet()
    {
        if (currentBullet > 0)
        {
            currentBullet = currentBullet - 1;
            countBulletText.text = currentBullet.ToString();
            if (currentBullet == 0)
                canShootPlayer = false;
        }
    }

    private void RestartBullet()
    {
        if (timer < timeRestart)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            currentBullet = currentBullet + 1;
            countBulletText.text = currentBullet.ToString();
            soundManager.PlaySongByIndex(6);

            canShootPlayer = true;
        }
    }
    
}
