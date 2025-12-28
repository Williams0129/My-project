
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
            FindObjectOfType<GameManager>().EndGame();// FindObjectOfType<GameManager>()這會去遍歷所有gameobject，直到找到型別是GameManager的component(這個型別指的是他的class確實叫
                                                      //GameManager)，再回傳那個class的參考
        }
    }
}
