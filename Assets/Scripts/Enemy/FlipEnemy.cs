using UnityEngine;

public class FlipEnemy : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    private SpriteRenderer sprite;
    private float vectorPl;


    private void Start()
    {
        
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        vectorPl = PlayerController.singletonPlayer.transformPlayer.position.x;
        float direction = transform.position.x - vectorPl;
        if (Mathf.Abs(direction) > 0.01f)
        {
            FlipEnemyMethod(direction);
        }
    }

    private void FlipEnemyMethod(float direction)
    {
        firePoint.localPosition = new Vector2(direction < 0 ? 0.2f : -0.2f, firePoint.localPosition.y);
        sprite.flipX = direction < 0 ? false : true;
    }
}
