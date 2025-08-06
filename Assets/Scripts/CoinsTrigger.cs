using UnityEngine;

public class CoinsTrigger : MonoBehaviour
{
    //[SerializeField] private CoinController coinController;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            CoinController.singletonCoin.Coin(1);
            gameObject.SetActive(false);
        }
    }
}
