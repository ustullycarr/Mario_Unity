using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject ThirdPersonController;

    private Vector3 offset;
    

        // Start is called before the first frame update
    void Start()
    {
         offset = transform.position - ThirdPersonController.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ThirdPersonController.transform.position + offset;
    }
}
