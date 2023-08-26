using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] KillPlayer instance;

    void OnEnable() {
        instance.gos.Add(this.gameObject);
    }
}
