using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Update()
    {
        if ((OVRInput.GetDown(OVRInput.RawButton.Y))) {
            Debug.Log("Detected Y");
            Play();
        }
    }
}
