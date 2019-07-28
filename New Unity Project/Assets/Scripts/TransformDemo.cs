using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformDemo : MonoBehaviour
{
	private void OnGUI()
	{
		
		if (GUILayout.Button("foreach - transform"))
		{
			foreach (Transform item in this.transform)
			{
				Debug.Log(item.name);
			}
		}

        if (GUILayout.Button("translate"))
        {
            //this.transform.Translate(0, 0, 1);
            this.transform.Translate(0, 0, 1, Space.World);
        }

        if (GUILayout.Button("Rotate"))
        {
            this.transform.Rotate(0, 0, 30);
        }

        if (GUILayout.Button("RotateAround"))
        {
            this.transform.RotateAround(Vector3.zero, Vector3.forward, 30);
        }
	}

}
