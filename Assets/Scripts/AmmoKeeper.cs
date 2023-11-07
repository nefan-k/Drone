using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AmmoKeeper
{
    public static int ammo { get; private set; } = 999;

    public static void DepleetAmmo()
    {
        ammo--;
    }

    public static void ResetAmmo()
    {
        ammo = 999;
    }
}
