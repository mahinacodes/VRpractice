using UnityEngine;

public class ShieldCollider : MonoBehaviour
{
    // Unity has a function OnCollisionEnter
    // To access more information call for Collision in the parenthesis
    
    public int collisionCount = 0;
    public bool detecting = false;
    PlayerHealth healthScript;

    void Start()
    {
        healthScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }
    
    public void startCollisionDetect(bool detect)
    {
        detecting = detect;
    }
   
    void OnCollisionEnter(Collision collisionInfo)
   {
        if (detecting == false)
        {
            return;
        }

        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log(collisionInfo.collider.tag);
            collisionCount += 1;
            Debug.Log(collisionCount);
            healthScript.UpdateHealth(1);
        }
   }

}