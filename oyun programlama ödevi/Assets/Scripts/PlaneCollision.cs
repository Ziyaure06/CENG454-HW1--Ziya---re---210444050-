
using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public class PlaneCollision : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision collision)
    {
        
       
        if (collision.gameObject.CompareTag("Structure"))
        {
            
            Structure hitStructure = collision.gameObject.GetComponent<Structure>();

            if (hitStructure != null)
            {
               
                Debug.Log($" Uçak kuleye çarptý! Hedef: {hitStructure.structureName}");
            }
            
        }
    }
}