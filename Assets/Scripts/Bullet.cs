using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private UseControllerSettings settings;
    [SerializeField] private Rigidbody2D rigidbody;

    public void Initialize(Vector3 vector3)
    {
        rigidbody.linearVelocity = vector3 * settings.SpeedBullet;
    }
}
