using Assets.Scrips;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;

    public float speed = 0.125f;
    public Vector3 offset;
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desPos = target.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desPos, speed);
        transform.position = smoothedPos;
    }
}
