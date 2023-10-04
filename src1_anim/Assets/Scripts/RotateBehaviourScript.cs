using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviourScript : MonoBehaviour
{

    void Update()
    {
        float rotate = 360 * Time.deltaTime/10f;

        this.transform.Rotate(0, rotate, 0);
    }
}
