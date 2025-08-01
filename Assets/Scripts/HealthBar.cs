using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image healthBar;

    public void GetDamageHealthBar(float current, float maxHealth)
    {
        healthBar.fillAmount = current / maxHealth;
    }
}
