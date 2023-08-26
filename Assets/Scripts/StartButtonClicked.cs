using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StartButtonClicked : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] Image sr;
    [Header("Images")]
    [SerializeField] Sprite compressed;
    [SerializeField] Sprite uncompressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        sr.sprite = compressed;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        sr.sprite = uncompressed;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
