using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TempMarker))]
public class TempMarkerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if(GUILayout.Button("Add Selected Object"))
        {
            TempMarker tempMarker = (TempMarker)target;
            GameObject obj = Selection.activeGameObject;
            int depth = 0;
            string path = "";
            while (obj.transform.parent != null)
            {
                depth += 1;
                path = obj.transform.GetSiblingIndex() + "," + path;
                obj = obj.transform.parent.gameObject;
            }
            path = depth + "," + path;
            tempMarker.toManipulatePath = path;
        }
    }
}
