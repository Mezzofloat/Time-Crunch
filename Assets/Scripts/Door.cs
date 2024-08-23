using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Door : MonoBehaviour, IConnection
{
    public void Activate() {
        Open();
    }

    void Open() {
        // transform.rotation = Quaternion.Euler(new Vector3(0,0, transform.rotation.eulerAngles.z - 90));
        transform.DORotate(new Vector3(0,0, transform.rotation.eulerAngles.z - 90), 1).SetEase(Ease.OutBounce);
    }
}
