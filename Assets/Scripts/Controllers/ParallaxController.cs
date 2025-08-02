using UnityEngine;

public class ParallaxController : MonoBehaviour     //не используется 
{ 
    [SerializeField] private GameObject[] layers;
    private Vector3 lastCameraPosition;
    [SerializeField] public float[] coeff;
    private float layersCount;

    private void Start()
    {
        layersCount = layers.Length;
        lastCameraPosition = Camera.main.transform.position;
    }

    private void LateUpdate()
    {
        Vector3 deltaMovement = Camera.main.transform.position - lastCameraPosition;

        for (int i = 0; i < layersCount; i++)
        {

            Vector3 movement = Vector3.zero;

            movement.x = deltaMovement.x * coeff[i];
            movement.y = deltaMovement.y * coeff[i];

            layers[i].transform.position += movement;
        }

        lastCameraPosition = Camera.main.transform.position;
    }
}
