﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CCTVCameraController : MonoBehaviour


{  //modyfikator prędkości obrotu
    public float turnSpeed = 5f;

//zakres obrotu kamery w stopniach
public float turnAngle = 90;

//czy kamera krêci siê w prawo
bool turningRight = !true;
    Transform CameraLens;
// Start is called before the first frame update
void Start()
{
 Transform cameraPosition = transform.Find("CameraPosition");
}

// Update is called once per frame
void Update()
{
    // mdyfikujemy rotacjê obiektu za pomoc¹ funkcji PingPong, która generuje wartoœci
    // oscyluj¹ce pomiêdzy 0 a 9, a nastêpnie mno¿ymy to przez 10 ¿eby uzyskaæ szybszy ruch
    // i na koniec odejmujemy od wartoœci otrzymanej 45 stopni aby uzyskaæ ruch w zakresie -45 do 45
    transform.rotation = Quaternion.Euler(new Vector3(0, Mathf.PingPong(Time.time, 9) * 10 - 45, 0));
        
        CheckifPlayerVisible();
}
    void CheckifPlayerVisible()
    {
        Debug.DrawRay(CameraLens.position, CameraLens.TransformDirection(Vector3.down) * 100, Color.yellow);
    }
}