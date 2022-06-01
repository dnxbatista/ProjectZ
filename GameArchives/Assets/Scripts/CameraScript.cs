using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject plr;

    private void Start()
    {
        transform.position = new Vector3(transform.position.x, -0.7894738f, -10);
    }
    void Update()
    {
       transform.position = new Vector3(transform.position.x , -0.7894738f, -10);
    }
}
