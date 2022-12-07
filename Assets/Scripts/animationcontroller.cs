using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class animationcontroller : MonoBehaviour
{
    private PlayableDirector arrowDirector;
    // Start is called before the first frame update
    void Start()
    {
        arrowDirector = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ArrowBegin()
    {
        arrowDirector.Play();
    }
}
