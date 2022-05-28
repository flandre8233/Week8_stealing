using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NTRShake : MonoBehaviour
{
    // Amplitude of the shake. A larger value shakes the camera harder.
    static float shakeAmount = 0.7f;

    void Update()
    {
        Vector3 NeedPosition = new Vector3() + (transform.rotation * Random.insideUnitCircle) * shakeAmount;
        transform.localPosition = Vector3.Lerp(transform.localPosition, NeedPosition, Time.deltaTime * 5);
    }

}
