using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentDemo : MonoBehaviour
{
    private void OnGUI() {
        if (GUILayout.Button("ClickMe"))
        {
            print("button clicked!");

            this.transform.position = new Vector3(0, 0, 10);
			this.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
