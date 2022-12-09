    using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[CustomStyle("CustomMarkerStyle")]
public class TempMarker :Marker,INotification,INotificationOptionProvider
{
    public string title;
    public Color color=Color.red;
    public string description;
    public bool showLineOverlay;
    public string toManipulatePath="";
    [Space(20)]
    [SerializeField] private bool retroactive = false;
    [SerializeField] private bool emitOnce = false;
    
    
    public PropertyName id => new PropertyName();

    public NotificationFlags flags => (NotificationFlags.TriggerInEditMode) ;

}
