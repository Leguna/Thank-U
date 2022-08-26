using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankU.Message
{
    public struct InputMoveMessage 

    {
        public Vector3 Direction { get; }

        public InputMoveMessage(Vector3 dir)
        {
            Direction = dir;
        }
    }
}
