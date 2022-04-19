using UnityEngine;

[CreateAssetMenu(fileName ="Equippable Items", menuName = "Equippables/Battery")]
public class Scriptable_Battery : ScriptableObject
{
    [Header ("Stats")]
    public float batteryPower;
    public float batteryCapacity;

    [Header("Description")]
    public string batteryName;
    public int batteryPrice;
    public string batteryDescription;

}
