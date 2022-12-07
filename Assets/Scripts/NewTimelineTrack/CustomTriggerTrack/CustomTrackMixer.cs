using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class CustomTrackMixer : PlayableBehaviour
{
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        float currentAlpha = 0f;
        int inputCount = playable.GetInputCount();
        for (int i = 0; i < inputCount; i++)
        {
            float inputWeight = playable.GetInputWeight(i);
            if (inputWeight > 0f)
            {
                ScriptPlayable<CustomTrackBehaviour> inputPlayable = (ScriptPlayable<CustomTrackBehaviour>)playable.GetInput(i);
                CustomTrackBehaviour input = inputPlayable.GetBehaviour();
                currentAlpha = inputWeight;
            }
        }

    }
}
