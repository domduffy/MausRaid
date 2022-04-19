using UnityEngine;

[CreateAssetMenu(fileName = "Equippable Items", menuName = "Equippables/Melee")]
public class Scriptable_Melee : ScriptableObject
{
    public enum weaponType { hammer, shortSword, longSword, gauntlet};
    public enum elementalType { fire, ice, electric, poison };

    [Header("Stats")]
    public float meleePower; // how powerful each blow is
    public float timeBetweenAttacks; // how quickly you can combo
    public float attackSpeed; // how quick each attack is
    public int meleeDurability; // how much weapon health damage is divided by
    public float meleeHealth;
    public float meleeMaxHealth;
    public float meleeStun; // how much stun is applied to enemy
    public float meleeDamage; // how much raw damage is applied to enemy
    public float meleeArmourDamage; // how much raw damage is applied to enemy

    [Header("Description")]
    public string meleeName;
    public int meleePrice;
    public string meleeDescription;
}
