using UnityEngine;

public class WalkingEnemy : MonoBehaviour
{
    [SerializeField] private AnimationController animationController;
    [SerializeField] private Transform firePoint;
    [SerializeField] private UseControllerSettings settings;
    [SerializeField] private Transform[] points;
    private SpriteRenderer sprite;
    private int currentPointIndex = 0;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        transform.position = points[0].position;
        currentPointIndex = 0;
        animationController.AnimatorEnemy("isMoving", true);
    }

    private void Update()
    {
        if (points.Length == 0) return;
        animationController.AnimatorEnemy("isMoving", true);

        Transform targetPoint = points[currentPointIndex];
        float distance = Vector2.Distance(transform.position, targetPoint.position);

        float distanceFlip = transform.position.x - targetPoint.position.x;
        FlipEnemyMoving(distanceFlip);

        transform.position = Vector2.MoveTowards(transform.position, targetPoint.position, settings.SpeedEnemy * Time.deltaTime);

        if (distance < 0.2f)
        {
            currentPointIndex = (currentPointIndex + 1) % points.Length;
        }
    }

    private void FlipEnemyMoving(float direction)
    {
        firePoint.localPosition = new Vector2(direction < 0 ? 0.3f : -0.3f, firePoint.localPosition.y);
        sprite.flipX = direction < 0? false : true;
    }
}
