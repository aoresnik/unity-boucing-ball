using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBehaviour : MonoBehaviour
{
    const float V0 = 7f;
        
    const float A = 9.81f;
        
    void Update()
    {
        float tOneBounce = (2 * V0) / A;
        float t = Time.time % tOneBounce;

        transform.localPosition = new Vector3(0f,1.0f,0f) * ((V0 * t) - (0.5f * A * (t * t)));
    }
}
