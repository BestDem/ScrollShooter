using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;

    private void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    private void FixedUpdate()
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        bool isJumpButtonPress = Input.GetButtonDown("Jump");
        bool isFireButtonPress = Input.GetButtonDown("Fire1");

        playerController.Movement(horizontalDirection, isJumpButtonPress, isFireButtonPress);
    }
}
