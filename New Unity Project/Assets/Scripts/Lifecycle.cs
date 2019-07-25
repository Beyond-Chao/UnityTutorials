using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifecycle : MonoBehaviour
{
    private void Awake() {
        Debug.Log("awake called " + Time.time + "-" + this.name);
    }

    private void Start() {
        Debug.Log("start called " + Time.time + "-" + this.name);
    }
}
