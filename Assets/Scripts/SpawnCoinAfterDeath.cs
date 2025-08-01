using UnityEngine;

public class SpawnCoinAfterDeath : MonoBehaviour
{
    [SerializeField] private CoinsTrigger coin;
    [SerializeField] private CheackPoint cheackPoint;

    public void SpawnCoin(Transform transformDeathEnemy)
    {
        CoinsTrigger bullett = Instantiate(coin, transformDeathEnemy.position, Quaternion.identity);
        //cheackPoint.AddCoinFromEnemy(bullett);
    }
}
