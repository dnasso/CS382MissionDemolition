using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // I'm gonna do buttons the same way I did them in the last project and attach a battery of functions as needed to the main camera

    public void restartButton() {
        Debug.Log("Restart Button Pressed");
        SceneManager.LoadScene( "_Scene_0" );
    }
}
