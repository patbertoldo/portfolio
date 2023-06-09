using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionService : IService
{
    public override void Initialize()
    {
        base.Initialize();

        Debug.Log($"{this.GetType()} Initialized");
    }
}
