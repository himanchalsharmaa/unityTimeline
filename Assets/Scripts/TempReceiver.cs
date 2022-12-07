using UnityEngine;
using UnityEngine.Playables;

public class TempReceiver : MonoBehaviour, INotificationReceiver
{
    public void OnNotify(Playable origin, INotification notification, object context)
    {
        if (notification is TempMarker tempMarkers)
        {
            Debug.Log(notification);
            PlayableDirector playableDirector = GetComponent<PlayableDirector>();
            playableDirector.Pause();
        }
            
    }
}


