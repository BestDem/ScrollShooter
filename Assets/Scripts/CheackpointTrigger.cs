using System.Collections.Generic;
using UnityEngine;

public class CheackpointTrigger : MonoBehaviour
{
    [SerializeField] private List<GameObject> coinsNextCheckpoints;
    [SerializeField] private int number;
    [SerializeField] private Cheackpoint cheackpoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            cheackpoint.ActivateNextCheckPoint(number);
        }
    }

    public void AddCoinInList(GameObject coin)
    {
        coinsNextCheckpoints.Add(coin);
    }

    public void ActiveCoins()
    {
        foreach (GameObject coin in coinsNextCheckpoints)
        {
            coin.SetActive(true);
        }
    }
    public void DestroyCoins()
    {
        foreach (GameObject coin in coinsNextCheckpoints)
        {
            Destroy(coin);
        }
    }
}
