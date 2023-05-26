using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public void OnTrigger Enter2D(Collider2D other)
    {   
        InventoryManager.instance.AddWeapon(weapon);
        Destroy (gameObject);
    }
}
