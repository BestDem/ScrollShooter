using UnityEngine;

public class JumpController : MonoBehaviour
{
    [SerializeField] private UseControllerSettings settings;
    [SerializeField] private Rigidbody2D rigidbody;
    public void Jump()
    {
        rigidbody.linearVelocity = new Vector2(rigidbody.linearVelocity.x, settings.Jump);
    }
}
