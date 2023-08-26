using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartTheGame() => Invoke("ClickStart", 0.5f);

    public void ClickStart() {
        SceneManager.LoadScene("SampleScene");
    }
}
