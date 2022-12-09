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
    public GameObject manipulatorRoot;
    private bool grabbed = false;
    void Awake()
    {
        
        if(playableDirector == null)
        {
            Debug.Log("NULL HERE");
        }
        else { Debug.Log("FOUND IT"); }
    }

    public void waitForGrab(GameObject toManipulate)
    {
        toManipulate.GetComponent<ObjectManipulator>().OnManipulationStarted.AddListener((e)=> playableDirector.Play());
    }


    }
