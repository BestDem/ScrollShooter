using System.Collections;
using UnityEngine;

public class DeathEnemy : MonoBehaviour
{
    public void DeathEnemyEvent()
    {
        Destroy(gameObject);
    }
}
