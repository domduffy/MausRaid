using UnityEngine;

[CreateAssetMenu(fileName = "Equippable Items", menuName = "Equippables/Jetpack")]
public class Scriptable_Jetpack : ScriptableObject
{
    [Header("Stats")]
    public float jetpackPower; // how stunned the enemies get
    public float jetpackCapacity; // how much steam you can store
    public float jetpackMaxCapacity;
    public float jetpackSteamUsage;

    [Header("Description")]
    public string jetpackName;
    public int jetpackPrice;
    public string jetpackDescription;
}
