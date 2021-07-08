using System;
using UnityEngine;

public class Idle : AbstractState
{
    public override void Update()
    {
        Debug.Log("Idle Update");
    }
}

public class Move : AbstractState
{
    public override void Update()
    {
        Debug.Log("Move Update");
    }
}

public class Attack : AbstractState
{
    public override void Update()
    {
        Debug.Log("Attack Update");
    }
}
