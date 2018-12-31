using KLD.Core.Configuration;
using KLD.Core.Projection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileConfig : ConfigMapper<Projectile>
{
    public bool DisableOnStart;

    public override void Configure(Projectile obj)
    {
        if (DisableOnStart)
        {
            obj.enabled = false;
        }
    }
}