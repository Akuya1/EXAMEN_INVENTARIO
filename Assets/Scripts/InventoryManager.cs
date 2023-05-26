using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public void AddWeapon (ScriptableWeapon weapon)
    {
        for(int i = 0; i < weapons.Lenght; i ++)
        {
            if(weapons [i] == null)
            {
                weapons[i] = item;
                weaponsNames[i].text =                             item.weaponName;
                weaponsSprites[i].sprite = itemweaponSprite;
                return;
            }
        }
    } 

}
