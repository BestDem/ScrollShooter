using UnityEngine;

public class MedicineChestTrigger : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private float hpAptecha;
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.TryGetComponent<Health>(out var health) && collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            health.ResetHP(hpAptecha);
            Destroy(gameObject);
        }
    }
}
