using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pit : MonoBehaviour
{
    [SerializeField] GameObject _connection;

    public IConnection connection() => _connection.GetComponent<IConnection>();

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag.Equals("Box")) {
            Destroy(other.gameObject);
            connection().Activate();
        }
    }
}
