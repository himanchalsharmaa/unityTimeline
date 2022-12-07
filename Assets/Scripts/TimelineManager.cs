using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelineManager : MonoBehaviour
{
    internal PlayableDirector playableDirector;
    void Start()
    {
         playableDirector = GetComponent<PlayableDirector>();
        if(playableDirector == null)
        {
            Debug.Log("NULL HERE");
        }
        else { Debug.Log("FOUND IT"); }
    }


    
}
