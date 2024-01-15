using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice_Cup : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera Cam;
    void OnMouseDrag()
    {
        transform.position = GetMousePos();
    }


    Vector3 GetMousePos()
    {
        var mousePos = Cam.ScreenToWorldPoint(Input.mousePosition);

        mousePos.z = 0;
        return mousePos;
    }
}