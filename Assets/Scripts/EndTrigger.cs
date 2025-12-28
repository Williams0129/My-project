
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gamemanager;
    public void OnTriggerEnter()
    {
        gamemanager.levelcomplete();
    }
}
