using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController singletonPlayer { get; private set; }
    [SerializeField] private JumpController jumpController;
    [SerializeField] private MovementController movementController;
    [SerializeField] private Transform groundColliderTransform;
    [SerializeField] private UseControllerSettings settings;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private ShootController shootController;
    [SerializeField] private bool isGrounded;
    private float groundCheckInterval = 0.1f; // Интервал проверки в секундах
    private float jumpOffSet = 0.05f;
    private float nextGroundCheckTime;
    private bool canMove = true;
    public Transform transformPlayer => groundColliderTransform;

    private void Awake()
    {
        if (singletonPlayer == null)
            singletonPlayer = this;
        else
            Destroy(gameObject);
    }
    public void Movement(float direction, bool isJump, bool canShoot)
    {
        if (canMove)
        {
            if (Time.time > nextGroundCheckTime)   //проверка на нахождение на земле и прыжок
            {
                ChechIsGrounded();
            }

            if (isGrounded || isJump == false)
            {
                movementController.Move(direction);
            }

            if (canShoot == true)
            {
                shootController.Shoot();
            }

            if (isJump & isGrounded)
            {
                AnimationPlayerController.singletonAnim.AnimatorPlayer("isJump", true);
                jumpController.Jump();
            }

            movementController.FlipSprite(direction);
        }
    }

    private void ChechIsGrounded()
    {
        isGrounded = Physics2D.OverlapCircle(groundColliderTransform.position, jumpOffSet, groundMask);
        nextGroundCheckTime = Time.time + groundCheckInterval;
    }

    public void CanMoveEnevt(bool canMove1)
    {
        canMove = canMove1;
    }
}
