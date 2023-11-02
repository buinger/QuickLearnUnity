using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{

    public float speed = 1f; 

    public Camera aimCamera;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float rotateY = Input.GetAxis("Mouse X")* speed;
        float rotateX = -Input.GetAxis("Mouse Y")* speed;
        Debug.Log(rotateY + "--" + rotateX);
        aimCamera.transform.eulerAngles= aimCamera.transform.eulerAngles +
            new Vector3(rotateX, rotateY, 0);
    }

}
