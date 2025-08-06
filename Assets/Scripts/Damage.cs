using System.Collections;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private string ignoreLayer;
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.layer == LayerMask.NameToLayer(ignoreLayer) || collider.gameObject.layer == LayerMask.NameToLayer("Ignore Raycast"))
            return;

        if (collider.gameObject.TryGetComponent<Health>(out var health))
        {
            health.GetDamage(damage);
            AnimationPlayerController.singletonAnim.AnimatorPlayer("isDamage", true);
        }
        Destroy(gameObject);
    }
}
