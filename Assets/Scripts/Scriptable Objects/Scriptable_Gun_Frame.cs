using UnityEngine;

[CreateAssetMenu(fileName = "Equippable Items", menuName = "Equippables/Gun Frame")]
public class Scriptable_Gun_Frame : ScriptableObject
{
    [Header("Stats")]
    public int gunLevel; // stat to determine if attachment is compatible

    [Header("Temp")] // Temp stats which will be refactored
    public float firePower;
    public float fireRate;
    public float reloadSpeed;
    public float heatUpSpeed;
    public float coolDownSpeed;
    public int ammoSize;
    public float secondaryFirePower;
    public float secondaryFireRate;
    public int secondaryFireUsage;

    public float primaryStun; // how much stun is applied to enemy
    public float primaryDamage; // how much raw damage is applied to enemy
    public float primaryArmourDamage; // how much raw damage is applied to enemy
    public float secondaryStun; // how much stun is applied to enemy
    public float secondaryDamage; // how much raw damage is applied to enemy
    public float secondaryArmourDamage; // how much raw damage is applied to enemy

    [Header("Description")]
    public string gunFrameName;
    public int gunFramePrice;
    public string gunFrameDescription;
}
