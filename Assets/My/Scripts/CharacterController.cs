using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Vector3 difference;

    private void Start()
    {
        Physics(true);
        //Colli(true);
    }

    private void OnMouseDown()
    {
        difference = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - difference);
        Physics(false);   
        //Colli(true);
    }

    public void Physics(bool status)
    {
        Rigidbody[] rb = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody childPhysics in rb)
        {
            childPhysics.isKinematic = status;
        }
    }

    //public void Colli(bool status)
    //{
    //    Collider[] col = GetComponentsInChildren<Collider>();
    //    foreach (Collider childCollider in col)
    //    {
    //        childCollider.enabled = status;
    //    }
    //}
}
