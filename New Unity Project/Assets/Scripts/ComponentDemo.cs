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
		}

        if (GUILayout.Button("GetComponent"))
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        if (GUILayout.Button("GetComponents"))
        {
            var allComponent = this.GetComponents<Component>();
            foreach (var item in allComponent)
            {
                Debug.Log(item.GetType());
            }
        }
    }

    private void OnMouseDown()
    {
        print("hello");
    }
}
