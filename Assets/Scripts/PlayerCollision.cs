
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Playermove playermove;
    void OnCollisionEnter(Collision collisioninfo)//碰撞發生時，Unity會自動產生一個Collision class的物件，並自動呼叫OnCollisionEnter(Collision collisioninfo)，裡面如果沒有Collision collisioninfo這種parameter，就什麼碰撞資訊都沒有
    {
        if (collisioninfo.collider.tag == "Obstacles") 
        {
            Debug.Log("We hit obstacle.");
            playermove.enabled = false;
        }
    }
}
