using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandMoveTo : CommandBase
{
    public Vector3 DestinationPoint;
    public LabAgent Agent;

    public override void Execute(LabAgent agent)
    {
        agent.agent.SetDestination(DestinationPoint);
    }

    public override bool OnCompleted(LabAgent agent)
    {
        return true; 
    }
}
