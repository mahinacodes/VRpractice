using UnityEngine;

public class ShieldCollider : MonoBehaviour
{
    // delete start functions
    // Unity has a function OnCollisionEnter
    // To access more information call for Collision in the parenthesis
    
   void OnCollisionEnter(Collision collisionInfo)
   {
        //print out the name of what we hit
        //Debug.Log(collisionInfo.collider.tag);

        //Also use an if statement (so it does not track the ground too)
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log(collisionInfo.collider.tag);
        }
   }
}