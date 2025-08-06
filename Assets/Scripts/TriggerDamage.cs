using System.Collections;
using UnityEngine;

public class TriggerDamage : MonoBehaviour
{
    [SerializeField] private float damage;
    private bool isDamage = true;

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.TryGetComponent<Health>(out var health) && isDamage && collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            isDamage = false;
            AnimationPlayerController.singletonAnim.AnimatorPlayer("isDamage", true);
            health.GetDamage(damage);
            StartCoroutine(WaiteSec());
        }
        else
            return;
    }

    IEnumerator WaiteSec()
    {
        yield return new WaitForSeconds(1f);
        isDamage = true;
    }
}
