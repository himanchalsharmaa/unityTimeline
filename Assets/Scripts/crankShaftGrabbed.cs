using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class crankShaftGrabbed : MonoBehaviour
{
    public PlayableDirector arrow1director;
    public PlayableDirector arrow2director;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShaftGrabbed()
    {
        arrow1director.Stop();
        arrow2director.Play();
    }
}
