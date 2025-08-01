using UnityEngine;

[CreateAssetMenu(fileName = "ControllerSettings", menuName = "Player/Controller Settings")]
public class UseControllerSettings : ScriptableObject
{
    [Tooltip("Пуля")]
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float beamRange;
    [SerializeField] private float damage;
    [SerializeField] private float speedBullet;

    [Tooltip("Персонаж")]
    [SerializeField] private GameObject player;
    [SerializeField] private float speedPlayer;
    [SerializeField] private float jump;

    [Tooltip("Враг")]
    [SerializeField] private float speedEnemy;
    [SerializeField] private float speedAgryEnemy;
    [SerializeField] private GameObject enemyPrefab;

    public GameObject BulletPrefab => bulletPrefab;
    public float BeamRange => beamRange;
    public GameObject PlayerPrefab => player;
    public float SpeedPlayer => speedPlayer;
    public float Jump => jump;
    public float Damage => damage;
    public float SpeedBullet => speedBullet;
    public float SpeedAgryEnemy => speedAgryEnemy;
    public float SpeedEnemy => speedEnemy;
    public GameObject EnemyPrefab => enemyPrefab;
}
