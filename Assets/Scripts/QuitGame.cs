using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    [SerializeField] GameObject quitButton;

    public void Quit() {
        // TODO: Change to Application.Quit() before building
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void ShowQuit() => quitButton.SetActive(true);
}
