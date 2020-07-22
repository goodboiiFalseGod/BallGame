using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 startPos;
    public Vector3 finishPos;

    public GameObject start;
    public GameObject finish;

    public Quaternion rotation;

    Transform[] childs;

    private void Start()
    {
        startPos = new Vector3(start.transform.position.x, start.transform.position.y, start.transform.position.z);
        finishPos = new Vector3(finish.transform.position.x, finish.transform.position.y, finish.transform.position.z);

        rotation = this.transform.rotation;
    }
}
