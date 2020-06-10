using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayButton() {
        SceneManager.LoadScene("Gameplay");
    }
    public void RestartButton() {
        SceneManager.LoadScene("Gameplay");
    }
}
