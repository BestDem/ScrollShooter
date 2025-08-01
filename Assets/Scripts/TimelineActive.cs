using UnityEngine;
using UnityEngine.Playables;

public class TimelineActive : MonoBehaviour
{
    private PlayableDirector timeline;
    private bool isStartTimeline = true;

    private void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }

    public void StartTimeline()
    {
        if (isStartTimeline)
        {
            timeline.Play();
            isStartTimeline = false;
        }
    }
}
