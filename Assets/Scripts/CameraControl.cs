using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject ball;
    public Vector3 difference;
    // Start is called before the first frame update
    void Start()
    {
        difference=transform.position-ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=ball.transform.position+difference;
    }
}
