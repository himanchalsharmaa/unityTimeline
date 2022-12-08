using UnityEngine;
using UnityEngine.Playables;

public class TempReceiver : MonoBehaviour, INotificationReceiver
{
    public void OnNotify(Playable origin, INotification notification, object context)
    {
        if (notification is TempMarker tempMarkers)
        {
            Debug.Log("Paused");
            TimelineManager timelineManager = GetComponent<TimelineManager>();
            PlayableDirector playableDirector = timelineManager.playableDirector;
            playableDirector.Pause();
            timelineManager.waitForGrab();
        }
            
    }
}


