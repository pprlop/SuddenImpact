using UnityEngine;

public class TestGun : Gun
{
    private float lastFireTime = -999f;
    public override void Attack(Vector3 direction)
    {
        if (!photonView.IsMine) return;
        if (IsAmmoEmpty()) return;
        if (Time.time - lastFireTime < 1f / fireRate) return;

        lastFireTime = Time.time;
        FireBullet(direction);
        curAmmo--;

        Debug.Log($"[ÃÑ] ³²Àº Åº: {curAmmo}/{maxAmmo}");
    }
}
