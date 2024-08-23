using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] MovePlayer mp;
    public List<GameObject> gos = new();

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag.Equals("Hand")) {
            Die();
        }
    }

    public void Die(bool shouldRestart = true) {
        gameOverScreen.SetActive(true);
        foreach (GameObject go in gos) {
            if (go != null) go.SetActive(false);
        }
        mp.SetFalse();
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        if (shouldRestart) Invoke("End", 1);
    }

    void End() => SceneManager.LoadScene("SampleScene");
}
