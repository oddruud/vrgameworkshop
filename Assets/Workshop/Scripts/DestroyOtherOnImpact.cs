using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider))]
public class DestroyOtherOnImpact : MonoBehaviour
{

    BoxCollider boxcollider;

    private void Awake()
    {
        boxcollider = GetComponent<BoxCollider>(); 
    }

    private void OnCollisionEnter(Collision c)
    {
        GameObject.Destroy(c.gameObject);
    }

    private void OnDrawGizmos()
    {

        if (boxcollider == null)
            boxcollider = GetComponent<BoxCollider>();

        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(boxcollider.bounds.center, boxcollider.bounds.size); 
    }


}
