using System.Collections.Generic;
using UnityEngine;

public class CheackPoint : MonoBehaviour
{
    [SerializeField] private List<GameObject> checkPoints;
    [SerializeField] private CoinController coinController;
    [SerializeField] private CheackpointTrigger[] cheackpointTrigger;
    [SerializeField] private GameObject player;
    [SerializeField] private Transform camera;
    private int activePoint = 0;
    public int ActiveCheackPoint => activePoint;

    private void Awake()
    {
        if (checkPoints.Count > 0)
        {
            activePoint = PlayerPrefs.GetInt("CheackPoint", 0);

            camera.transform.position = new Vector3(checkPoints[activePoint].transform.position.x, checkPoints[activePoint].transform.position.y, -1);
            player.transform.position = checkPoints[activePoint].transform.position;
        }
    }

    public void SpawnPlayer()
    {
        activePoint = PlayerPrefs.GetInt("CheackPoint", 0);
        player.transform.position = checkPoints[activePoint].transform.position;
        coinController.RestartCoinOnTrigger();
    }

    public void ActivateNextCheckPoint(int numberCheackPoint)
    {
        if (numberCheackPoint != PlayerPrefs.GetInt("CheackPoint"))
        {
            Debug.Log(numberCheackPoint);
            coinController.SaveCoinAfterTrigger();
            cheackpointTrigger[activePoint].DestroyCoins();
            activePoint = numberCheackPoint;

            PlayerPrefs.SetInt("CheackPoint", numberCheackPoint);
        }
    }

    public void ActiveCoinsAfterDeath()
    {
        cheackpointTrigger[activePoint].ActiveCoins();
    }

    public void AddCoinFromEnemy(GameObject coin)
    {
        cheackpointTrigger[activePoint].AddCoinInList(coin);
    }

    public void ResetPoints()
    {
        PlayerPrefs.SetInt("CheackPoint", 0);
        activePoint = 0;
    }
}
