using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Input;

public class TimelineManager : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public GameObject grabbable;
    private bool grabbed = false;
    void Awake()
    {
        
        if(playableDirector == null)
        {
            Debug.Log("NULL HERE");
        }
        else { Debug.Log("FOUND IT"); }
    }

    public void waitForGrab()
    {
        grabbable.GetComponent<ObjectManipulator>().OnManipulationStarted.AddListener((e)=> playableDirector.Play());
        
    }


    }
