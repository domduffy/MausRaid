using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquippables : MonoBehaviour
{
    public virtual void SetLocation(Transform parentBone)
    {
        transform.SetParent(parentBone);
    }
}
