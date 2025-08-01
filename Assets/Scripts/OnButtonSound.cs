using UnityEngine;

public class OnButtonSound : MonoBehaviour
{
    [SerializeField] private int indexSound;
    private SoundManager soundManager;
    private void Start()
    {
        soundManager = GetComponent<SoundManager>();
    }

    public void SoundButton()
    {
        soundManager.PlaySongByIndex(indexSound);
    }
}
