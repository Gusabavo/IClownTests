﻿namespace IClownTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClown fingersTheClown = new ScaryScary("big red nose", 14);
            fingersTheClown.Honk();
            if(fingersTheClown is IScaryClown iSCaryClownReference)
            {
                iSCaryClownReference.ScareLittleChildren();
            }
        }
    }
}
