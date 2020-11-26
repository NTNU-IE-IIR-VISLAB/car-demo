using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRestart : MonoBehaviour {
    Vector3 startpos;
    // Start is called before the first frame update
    void Start () {
        this.startpos = this.transform.position;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey (KeyCode.R)) {
            this.transform.position = startpos;
        }
        if (Input.GetKey (KeyCode.Escape)) {
            Application.Quit();
        }
    }
}