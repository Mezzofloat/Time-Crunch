using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

public class MoveHands : MonoBehaviour
{
    [SerializeField] Transform minuteHand, minuteHandOverimage, hourHand, hourHandOverimage;
    [SerializeField] Image arc;
    [Range(0,40)] [SerializeField] float rotationSpeed = 20;

    const float HOURS_TO_ROTATION = Mathf.PI * 2 * Mathf.Rad2Deg / (30);

    float time;

    void Awake() {
        arc.fillAmount = 0;
    }

    void Update()
    {
        minuteHand.rotation = Quaternion.Euler(0, 0, -time * rotationSpeed);
        hourHand.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(0, -HOURS_TO_ROTATION, time / 60));

        time += Time.deltaTime;

        arc.fillAmount = (360 - minuteHand.rotation.eulerAngles.z) / 360;

        minuteHandOverimage.rotation = Quaternion.Euler(minuteHand.rotation.eulerAngles + new Vector3(0,0,90));
        hourHandOverimage.rotation = hourHand.rotation;
    }
}
