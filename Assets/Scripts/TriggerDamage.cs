using System.Collections;
using UnityEngine;

public class TriggerDamage : MonoBehaviour
{
    [SerializeField] private float damage;
    private bool isDamage = true;

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.TryGetComponent<Health>(out var health) && isDamage)
        {
            isDamage = false;
            AnimationPlayerController.singltonAnim.AnimatorPlayer("isDamage", true);
            health.GetDamage(damage);
            StartCoroutine(WaiteSec());
        }
    }

    IEnumerator WaiteSec()
    {
        yield return new WaitForSeconds(1f);
        isDamage = true;
    }
}
