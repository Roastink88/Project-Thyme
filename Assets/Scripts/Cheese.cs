using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : MonoBehaviour
{
    public float rotateSpeed;

    private void Update()
    {
        //rotates the milk
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);

    }
}
