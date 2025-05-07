using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.Feedbacks; 

[CreateAssetMenu(fileName = "ItemAbilityPickups", menuName = "Scriptable Objects/ItemAbilityPickups")]
public class ItemAbilityPickups : ScriptableObject
{
    public string name;
    public string description;

    public Sprite artwork;
    public float healthAdjust;
    public float JumpHeight;
    public float jumpSpeed;
    public float moveSpeed;
    public float MinimumDamageFallHeight;
    public int MaxDamageFallHeight;
}
