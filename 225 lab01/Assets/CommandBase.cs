using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CommandBase
{

    public virtual void Execute(LabAgent agent)
    {

    }

    public virtual bool OnCompleted(LabAgent agent)
    {
        return false;
    }
}
