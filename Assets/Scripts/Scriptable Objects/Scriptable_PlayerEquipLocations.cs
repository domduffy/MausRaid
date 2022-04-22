using UnityEngine;

[CreateAssetMenu(fileName = "Equip Locations", menuName = "Equip Locations")]
public class Scriptable_PlayerEquipLocations : ScriptableObject
{
    [Header("Equippable Locations")]
    public Transform swordLocation, gunLocation, batteryLocation, jetpackLocation;
}
