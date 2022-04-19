using UnityEngine;

[CreateAssetMenu(fileName = "Equippable Items", menuName = "Equippables/Gun Attachment/Primary")]
public class Scriptable_Gun_Attachment_Primary : ScriptableObject
{
    [Header("GunType")]
    public int gunLevel;
    public enum gunType { rapidFire, sniper, charge };

    [Header("Stats")]
    public float firePower;
    public float fireRate;
    public float readySpeed; // how quickly you can fire the shot from idle
    public float reloadSpeed; // time between shots
    public float heatUpSpeed;
    public float coolDownSpeed;
    public int ammoSize;
    public float primaryStun; // how much stun is applied to enemy
    public float primaryDamage; // how much raw damage is applied to enemy
    public float primaryArmourDamage; // how much raw damage is applied to enemy

    [Header("Description")]
    public string primaryGunName;
    public int primaryGunPrice;
    public string primaryGunDescription;
}
