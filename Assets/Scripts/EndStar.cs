using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndStar : MonoBehaviour, IConnection
{
    [SerializeField] private GameObject winScreen;
    [SerializeField] private QuitGame quitManager;

    public void Activate() {
        gameObject.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name.Equals("Player")) {
            winScreen.SetActive(true);
            Invoke("quitManager.ShowQuit", 2);
            other.GetComponent<KillPlayer>().Die(false);
        }
    }
}
