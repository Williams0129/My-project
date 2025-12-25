

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public Rigidbody rs;
    public float forwardforce = 200f;
    public float sideforce = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Update會跟隨螢幕的禛綠每次更新都會呼叫
    // FixedUpdate是每秒固定更新次數，用在物理移動上才不會有加速度不一樣的感覺
    void FixedUpdate()
    {
        rs.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetKey("d")) 
        {
            rs.AddForce(sideforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rs.AddForce(-sideforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
    }
}
