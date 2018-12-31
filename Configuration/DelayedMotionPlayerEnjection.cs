using System.Collections;
using System.Collections.Generic;
using KLD.Core;
using KLD.Core.Player;

using KLD.Core.Projection;
using UnityEngine;

namespace KLD.Core.Configuration
{
    [RequireComponent(typeof(DelayedMotion))]
    public class DelayedMotionPlayerEnjection : Enjection
    {

        public DelayedMotion DelayedMotion;

        public override void Enject(Player.Player p)
        {
            DelayedMotion.LookAt.SetRotationFacing(p.transform);
        }

        private void OnValidate()
        {
            if (DelayedMotion == null)
            {
                DelayedMotion = GetComponent<DelayedMotion>();
            }
        }

    } 
}
