using System.Collections.Generic;
using UnityEngine;

public class CheackpointTrigger : MonoBehaviour
{
    [SerializeField] private List<GameObject> coinsNextCheckPoints;
    [SerializeField] private int number;
    [SerializeField] private CheackPoint cheackPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            cheackPoint.ActivateNextCheckPoint(number);
        }
    }

    public void AddCoinInList(GameObject coin)
    {
        coinsNextCheckPoints.Add(coin);
    }

    public void ActiveCoins()
    {
        {
            foreach (GameObject coin in coinsNextCheckPoints)
            {
                coin.SetActive(true);
            }
        }
    }
    public void DestroyCoins()
    {
        {
            foreach (GameObject coin in coinsNextCheckPoints)
            {
                Destroy(coin);
            }
        }
    }
}
