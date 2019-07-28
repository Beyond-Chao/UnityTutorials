using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectDemo : MonoBehaviour
{

    private void OnGUI()
    {
        if (GUILayout.Button("Add Light"))
        {
            GameObject lightGO = new GameObject();
            Light light = lightGO.AddComponent<Light>();
            light.color = Color.red;
            light.type = LightType.Point;
        }
    }
}
