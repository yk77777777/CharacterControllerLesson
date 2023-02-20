using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void LateUpdate()
    {
        //向いている方向に進める
        transform.position = player.position + (-player.forward * 3.0f) + (player.up * 1.0f);
        //GameObjectにz軸を向ける
        transform.LookAt (player.position + Vector3.up);
    }
}
