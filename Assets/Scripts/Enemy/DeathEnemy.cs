using System.Collections;
using UnityEngine;

public class DeathEnemy : MonoBehaviour
{
    [SerializeField] private SoundManager sound;
    public void DeathEnemyEvent()
    {
        //sound.PlaySongByIndex(4);
        Destroy(gameObject);
    }
}
