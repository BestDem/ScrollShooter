using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] private float damage;
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.layer == LayerMask.NameToLayer("Player") || collider.gameObject.layer == LayerMask.NameToLayer("Ignore Raycast"))
            return;

        if (collider.gameObject.TryGetComponent<Health>(out var health))
        {
            health.GetDamage(damage);
        }
        Destroy(gameObject);
    }
}
