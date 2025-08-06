using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    public static CoinController singletonCoin { get; private set; }
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private Text text;
    private float coinCheckpoint = 0;

    private void Awake()
    {
        if (singletonCoin == null)
            singletonCoin = this;
        else
            Destroy(gameObject);
    }
    private void Start()
    {
        coinCheckpoint = PlayerPrefs.GetFloat("Coins");
        text.text = coinCheckpoint.ToString();
    }

    public void Coin(float coin)
    {
        coinCheckpoint += coin;
        text.text = coinCheckpoint.ToString();
        soundManager.PlaySongByIndex(3);
    }

    public void RestartCoinOnTrigger()
    {
        coinCheckpoint = PlayerPrefs.GetFloat("Coins");
        text.text = coinCheckpoint.ToString();
    }

    public void SaveCoinAfterTrigger()
    {
        PlayerPrefs.SetFloat("Coins", coinCheckpoint);
    }

    public void SetNullCoin()
    {
        PlayerPrefs.SetFloat("Coins", 0);
        coinCheckpoint = 0;
        text.text = coinCheckpoint.ToString();
    }
}
