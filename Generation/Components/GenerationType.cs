using System;


namespace KLD.Core.Generation
{
    [Flags]
    public enum GenerationType
    {
        Internal = 0,
        External = 1,
        Cooldown = 2
    }
}

