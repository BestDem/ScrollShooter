using UnityEngine;

public class EnemyShootTrigger : MonoBehaviour
{
    [SerializeField] private ShootingEnenmy shootingEnenmy;

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            shootingEnenmy.ShootEnemy(other.transform);
        }
    }
}
