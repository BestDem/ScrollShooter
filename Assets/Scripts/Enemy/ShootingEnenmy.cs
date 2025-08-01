using System.Collections;
using System.Linq;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class ShootingEnenmy : MonoBehaviour
{
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private float timeShooting = 1f;
    [SerializeField] private AnimationController animationController;
    [SerializeField] private Animator animator;
    [SerializeField] private Bullet bullet;
    [SerializeField] private Transform firePoint;
    private bool isBusy = false;

    public void ShootEnemy(Transform playerTransform)
    {
        if (isBusy == false)
        {
            soundManager.PlaySongByIndex(1);
            animationController.AnimatorEnemy("isAttack", true);
            Bullet bulletEnemy = Instantiate(bullet, firePoint.position, Quaternion.identity);

            // Вектор направления от точки выстрела к игроку
            Vector2 direction = (playerTransform.position - firePoint.position).normalized;

            bulletEnemy.Initialize(direction);
            StartCoroutine(ShootCoroutine());
        }
    }

    IEnumerator ShootCoroutine()
    {
        isBusy = true;
        yield return new WaitForSeconds(timeShooting);
        animator.SetBool("isAttack", false);
        isBusy = false;
    }
}
