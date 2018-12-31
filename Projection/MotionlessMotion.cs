using UnityEngine;

namespace KLD.Core.Projection
{
    public class MotionlessMotion : Motion
    {
        public override Vector2 Default()
        {
            return Vector2.zero;
        }

        public override Vector2 GetRelativeOffset(Vector2 defaultVector)
        {
            return defaultVector;
        }
    }
}
