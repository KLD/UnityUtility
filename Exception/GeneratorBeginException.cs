using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KLD.Core.Exceptions
{
    public class GeneratorBeginException : Exception
    {
        public GeneratorBeginException(string message) : base(message)
        {
        }
    }
}
