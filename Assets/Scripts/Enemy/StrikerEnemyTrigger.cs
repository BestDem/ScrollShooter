using UnityEngine;

public class StrikerEnemyTrigger : MonoBehaviour
{
    [SerializeField] private StrickerEnemy strickerEnemy;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
            strickerEnemy.GetAgryEnemy(collision.transform);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
            strickerEnemy.GetKindEnenmy();
    }
}
