using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject camerapos;
    public float x, y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //マウスの移動を取得
        y = Input.GetAxis("Mouse Y");
        x = Input.GetAxis("Mouse X");

        gameObject.transform.Rotate(0, x, 0);
        camerapos.transform.Rotate(-y, 0, 0);

    }
}
