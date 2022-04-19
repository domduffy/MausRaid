using UnityEngine;

[CreateAssetMenu(fileName = "Equippable Items", menuName = "Equippables/Gun Attachment/Secondary")]
public class Scriptable_Gun_Attachment_Secondary : ScriptableObject
{
    [Header("GunType")]
    public int gunLevel;
    public enum gunType { flamer, shotgun, charge};
    [Header("Stats")]
    public float secondaryFirePower;
    public float secondaryFireRate;
    public int secondaryFireUsage;
    public float secondaryStun; // how much stun is applied to enemy
    public float secondaryDamage; // how much raw damage is applied to enemy
    public float secondaryArmourDamage; // how much raw damage is applied to enemy

    [Header("Description")]
    public string secondaryGunName;
    public int secondaryGunPrice;
    public string secondaryGunDescription;
}
