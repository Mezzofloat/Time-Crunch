using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Pit : MonoBehaviour
{
    [SerializeField] GameObject _connection;

    public IConnection connection() => _connection.GetComponent<IConnection>();

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Box")) {
            other.transform.DOScale(0,1).OnComplete(() => Destroy(other.gameObject));
            other.transform.DORotate(new Vector3(transform.rotation.x,transform.rotation.y,transform.rotation.z + 360),1,RotateMode.FastBeyond360).SetEase(Ease.Linear);
            other.transform.DOMove(transform.position + Vector3.down * 0.1f, 1).SetEase(Ease.OutExpo);
            other.GetComponent<BoxCollider2D>().enabled = false;
            connection().Activate();
        }
    }
}
