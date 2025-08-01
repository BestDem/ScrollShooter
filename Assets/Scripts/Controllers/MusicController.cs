using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ControllerSettings", menuName = "Music Settings")]
public class MusicController : ScriptableObject
{
    [SerializeField] private AudioClip[] audioClips;
    [SerializeField] private AudioClip music;
    public AudioClip CurrentClip => audioClips[currentClipIndex];
    private int currentClipIndex = 0;

    public AudioClip GetClipByIndex(int index)
    {
        if (index >= 0 && index < audioClips.Length)
            return audioClips[index];
        return null;
    }

    public void SetSpecificClip(int index)
    {
        if (index >= 0 && index < audioClips.Length)
            currentClipIndex = index;
    }

    public int GetCurrentIndex()
    {
        return currentClipIndex;
    }

    //public bool IsPlaying()
    //{
        //return audioClip[currentClipIndex].isPlaying;
    //}
}