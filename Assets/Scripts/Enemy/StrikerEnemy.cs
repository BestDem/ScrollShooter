using NUnit.Framework;
using UnityEngine;

public class StrikerEnemy : MonoBehaviour
{
    [SerializeField] private AnimationController animationController;
    [SerializeField] private UseControllerSettings settings;
    [SerializeField] private ShootingEnenmy shootingEnenmy;


    public void GetAggroEnemy(Transform player)
    {
        animationController.AnimatorEnemy("isMoving", true);
        Vector2 vector = (player.position - transform.position).normalized;
        transform.position = Vector2.MoveTowards(transform.position, player.position, settings.SpeedAgryEnemy * Time.deltaTime);

        float distance = Vector2.Distance(transform.position, player.position);

        if (distance < 1)
            shootingEnenmy.ShootEnemy(player.transform);
    }

    public void GetKindEnenmy()
    {
        animationController.AnimatorEnemy("isMoving", false);
    }

}
