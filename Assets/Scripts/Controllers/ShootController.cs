using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class ShootController : MonoBehaviour
{
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private UseControllerSettings settings;
    [SerializeField] private Transform firePoint;
    [SerializeField] private Bullet bullet;
    [SerializeField] private ShieldActivation shield;
    [SerializeField] private BulletCounter bulletCounter;
    [SerializeField] private Animator animatorFire;


    public void Shoot()
    {
        if (shield.CanShoot && bulletCounter.CanShootPlayer)
        {
            AnimationPlayerController.singltonAnim.AnimatorPlayer("Attack", true);
            animatorFire.SetTrigger("isFire");
            soundManager.PlaySongByIndex(0);
            bulletCounter.AttackBullet();

            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (mouseWorldPos - firePoint.position).normalized;
            RaycastHit2D anyHit = Physics2D.Raycast(firePoint.position, direction, settings.BeamRange);

            Bullet bullett = Instantiate(bullet, firePoint.position, Quaternion.identity);
            Physics.IgnoreLayerCollision(3, 4);
            bullett.Initialize(direction);

            // Рисуем луч для отладки
            Debug.DrawLine(firePoint.position, firePoint.position + (Vector3)direction * settings.BeamRange, Color.red);
        }
        else if (bulletCounter.CurrentBullet == 0)
            soundManager.PlaySongByIndex(5);
    }
}
