using UnityEngine;

public class ShieldActivation : MonoBehaviour
{
    [SerializeField] private GameObject shield;
    private bool canShoot = false;    //в начале нужно false!!!!!!!!
    public bool CanShoot => canShoot;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            shield.SetActive(true);
            canShoot = false;
        }
        if (Input.GetMouseButtonUp(1))
        {
            shield.SetActive(false);
            canShoot = true;
        }
    }

    public void OnButtonCanShoot(bool canShootButton)
    {
        canShoot = canShootButton;
    }
}
