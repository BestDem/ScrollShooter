using UnityEngine;

public class TriggerBoss : MonoBehaviour
{
    [SerializeField] private ShootingEnenmy shootingEnenmy;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
            shootingEnenmy.ShootEnemy(collision.transform);
    }
}
