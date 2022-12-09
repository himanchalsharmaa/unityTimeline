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
            string path = tempMarkers.toManipulatePath;
            string[] pathway = path.Split(',');
            GameObject go = timelineManager.manipulatorRoot.transform.GetChild(int.Parse(pathway[1])).gameObject;
            if (int.Parse(pathway[0]) > 1)
            {
                for (int i = 2; i < int.Parse(pathway[0]) + 1; i++)
                {
                    go = go.transform.GetChild(int.Parse(pathway[i])).gameObject;
                }
            }
            timelineManager.waitForGrab(go);
        }
            
    }
}


