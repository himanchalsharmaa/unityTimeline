using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CustomClip : PlayableAsset
{
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<CustomTrackBehaviour>.Create(graph);
        CustomTrackBehaviour customTrackBehaviour = playable.GetBehaviour();
        return playable;
    }
}
