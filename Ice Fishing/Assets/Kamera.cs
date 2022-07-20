using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Kamera : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed = 0.1f;
    public float cameraPositionY;
    public float cameraPositionZ;
    public float cameraPositionX;
    public float cameraRotationX;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(cameraRotationX, 0f, 0f);
        transform.position = Vector3.Slerp(transform.position, new Vector3(target.position.x + cameraPositionX , target.position.y + cameraPositionY, target.position.z + cameraPositionZ), cameraSpeed);

    }
}