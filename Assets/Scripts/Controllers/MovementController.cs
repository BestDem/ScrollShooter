using System;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private UseControllerSettings settings;
    [SerializeField] private Transform firePoint;
    [SerializeField] private Transform shieldPoint;
    private Rigidbody2D rigidbody;
    private SpriteRenderer spriteRenderer;
    private float currentSpeed = 0f;
    private float lastDirection = 1f; // 1 — вправо, -1 — влево

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void FlipSprite(float direction)
    {
        // Если direction == 0, используем последнее направление
        float flipDir = direction != 0 ? direction : lastDirection;
        spriteRenderer.flipX = flipDir < 0;
        firePoint.localPosition = new Vector2(flipDir > 0 ? 0.43f : -0.17f, firePoint.localPosition.y);
        shieldPoint.localPosition = new Vector2(flipDir > 0 ? 0.3f : -0.3f, shieldPoint.localPosition.y);
    }

    public void Move(float direction)
    {
        float targetSpeed = direction * settings.SpeedPlayer;
        currentSpeed = Mathf.MoveTowards(currentSpeed, targetSpeed, 10 * Time.fixedDeltaTime);
        rigidbody.linearVelocity = new Vector2(currentSpeed, rigidbody.linearVelocity.y);

        if (direction != 0)
        {
            AnimationPlayerController.singletonAnim.AnimatorPlayer("isRunning", true);
            lastDirection = direction; // Запоминаем последнее направление
        }
        else
        {
            AnimationPlayerController.singletonAnim.AnimatorPlayer("isRunning", false);
        }

        FlipSprite(direction); // Всегда вызываем флип
    }

    public void SetAnimationAfterDeath()
    {
        AnimationPlayerController.singletonAnim.AnimatorPlayer("Death", false);
        AnimationPlayerController.singletonAnim.AnimatorPlayer("isRunning", false);
        gameObject.layer = LayerMask.NameToLayer("Player");
    }
}
