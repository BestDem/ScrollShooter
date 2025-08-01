using UnityEngine;
using UnityEngine.UI;

public class SetActiveTrigger : MonoBehaviour
{
    [SerializeField] private float needCoinsToGo;
    [SerializeField] private Text numberCoins;
    [SerializeField] private GameObject canGoImage;
    [SerializeField] private GameObject needMoneyImage;
    [SerializeField] private GameObject barrier;
    private float coins;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            float.TryParse(numberCoins.text, out coins);
            ActiveCoinsImage(coins);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            canGoImage.SetActive(false);
            needMoneyImage.SetActive(false);
        }
    }

    private void ActiveCoinsImage(float coins)
    {
        if (coins <= needCoinsToGo)
            needMoneyImage.SetActive(true);
        else
        {
            canGoImage.SetActive(true);
            barrier.SetActive(false);
        }
    }
}
