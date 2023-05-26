using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Items/New Weapon/New Sword")]

public class ScriptableWeapon : ScriptableObject
{
    public string weaponName;

    public string weaponDescription;

    public Sprite weaponSprite;

    public float weaponDamage;

    public float weaponMagicDamage;

    public enum WeaponType
  
    {  
        sword,
        staff,
    }
}

