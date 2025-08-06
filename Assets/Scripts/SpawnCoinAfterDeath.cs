using UnityEngine;

public class SpawnCoinAfterDeath : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private Cheackpoint cheackPoint;
    private GameObject bullet;

    public void SpawnCoin(Transform transformDeathEnemy)
    {
        bullet = Instantiate(coin, transformDeathEnemy.position, transformDeathEnemy.rotation);

        cheackPoint.AddCoinFromEnemy(bullet);
    }
}
