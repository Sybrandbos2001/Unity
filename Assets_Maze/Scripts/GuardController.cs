using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardController : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 2.0f;

    private float progress = 0.0f; // Voortgang tussen de punten
    private bool goingToB = true; // Controleert richting van beweging

    void Update()
    {
        if (goingToB)
        {
            progress += speed * Time.deltaTime;
            if (progress >= 1.0f)
            {
                progress = 1.0f;
                goingToB = false; // Keert de bewegingsrichting om
            }
        }
        else
        {
            progress -= speed * Time.deltaTime;
            if (progress <= 0.0f)
            {
                progress = 0.0f;
                goingToB = true; // Keert de bewegingsrichting om
            }
        }

        transform.position = Vector3.Lerp(pointA.position, pointB.position, progress);
    }
}
