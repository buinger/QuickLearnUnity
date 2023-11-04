using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller1th : MonoBehaviour
{
    public Transform face;

   public float mouseSpeed = 10;

    [Range(0,100)]
    public float moveSpeed = 0.5f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //获取鼠标移动偏移值
        float mouseH = Input.GetAxis("Mouse X");
        float mouseV = Input.GetAxis("Mouse Y");

        Vector3 nowEuler = face.localEulerAngles;

        float testX = face.localEulerAngles.x - mouseV;

        if ((testX >= 270&&testX<=360) || (testX <=90&&testX>=0))
        {
            Vector3 eulerOffset = new Vector3(-mouseV, mouseH, 0);
            nowEuler.z = 0;
            face.localEulerAngles = nowEuler + eulerOffset * mouseSpeed * Time.deltaTime; 
        }

        //限定在270-360；0-90
        Debug.Log("当前x欧拉值：" + face.localEulerAngles);


        Vector3 faceDir = face.forward;
        Vector3 aimdir = faceDir;
        aimdir.y = 0;

        Vector3 faceDir2 = face.right;
        Vector3 aimdir2 = faceDir2;
        aimdir2.y = 0;


        //获取键盘方向输入值
        float keyH = Input.GetAxis("Horizontal");
        float keyV = Input.GetAxis("Vertical");

        Debug.Log(keyH + "-----" + keyV);


        Vector3 offset1 = aimdir * keyV*moveSpeed;
        Vector3 offset2 = aimdir2 * keyH*moveSpeed;

        Vector3 aimMoveOffset = (offset1 + offset2)*Time.deltaTime;

        transform.position = transform.position + aimMoveOffset;



    }
}
