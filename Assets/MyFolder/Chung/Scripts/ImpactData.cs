using UnityEngine;

public enum DamageType
{
    Bullet,
    Melee,
    Throw
}

public struct ImpactData
{
    public float damage;
    public int attackerActorNumber;  // PhotonNetwork.LocalPlayer.ActorNumber
    public int attackerTeam;
    public DamageType type;
    public Vector3 hitPoint;
    public Vector3 hitNormal;
}

