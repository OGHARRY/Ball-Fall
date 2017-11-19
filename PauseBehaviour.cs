using System.Collections;
using UnityEngine;

public class PauseBehaviour : MonoBehaviour {

    public bool paused;
    // Use this for initialization
    void Start() {
        paused = false;
    }

    // Update is called once per frame
    void Update() {

    }

    public void Pause() {

        if (paused) {
            Time.timeScale = 0;
        } else if (!paused) {
            Time.timeScale = 1;
        }
}
}
