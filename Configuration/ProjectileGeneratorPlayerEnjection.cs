using System.Collections;
using System.Collections.Generic;
using KLD.Core.Generation;
using KLD.Core.Player;
using UnityEngine;

namespace KLD.Core.Configuration
{
    [RequireComponent(typeof(ProjectileGenerator))]
    public class ProjectileGeneratorPlayerEnjection : Enjection
    {
        public ProjectileGenerator ProjectileGenerator;

        public override void Enject(Player.Player p)
        {
            ProjectileGenerator.GenerateAt.SetRotationFacing(p.transform);
        }

        private void OnValidate()
        {
            if (ProjectileGenerator == null)
            {
                ProjectileGenerator = GetComponent<ProjectileGenerator>();
            }
        }
    } 
}
