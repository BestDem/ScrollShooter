using UnityEngine;

public class WindTrigger : MonoBehaviour
{
    [SerializeField] private float powerWind;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up * powerWind, ForceMode2D.Impulse);
        }
    }
}
