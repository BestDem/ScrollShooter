using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private UseControllerSettings settings;
    [SerializeField] private Transform[] spawnPoints;
    private bool isBusy = false;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player") && isBusy == false)
        {
            StartCoroutine(TimerSpawn());
        }
    }
    IEnumerator TimerSpawn()
    {
        isBusy = true;
        yield return new WaitForSecondsRealtime(5f);

        float quantity = spawnPoints.Length;
        float randomPoint = Random.Range(0, quantity);
        GameObject enemy = Instantiate(settings.EnemyPrefab, spawnPoints[(int)randomPoint]);
        
        isBusy = false;
    }
}
