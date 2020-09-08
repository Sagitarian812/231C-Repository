using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LabAgent : MonoBehaviour
{
    public List<CommandBase> CommandList;
    public int commandIndex;
    public GameObject MovementPoint;
    public NavMeshAgent agent;
    public Vector3 StartingPoint;
  

    private void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        StartingPoint = transform.position;
        CommandList = new List<CommandBase>();
    }

    public void AddMoveCommand(Vector3 Destination)
    {
        CommandMoveTo MT = new CommandMoveTo() { DestinationPoint = Destination };
        CommandList.Add(MT);
        Instantiate(MovementPoint, Destination, Quaternion.identity);
        MT.Execute(this);
        commandIndex += 1;
        Debug.Log("CURRENT COMMAND IS: " + commandIndex);
        CycleCommand();
    }

    public void CycleCommand()
    {
        if( Input.GetKeyDown(KeyCode.Tab))
        {
            commandIndex -= 1;
            Debug.Log("CURRENT COMMAND IS: " + commandIndex);
        }

    }
    public void ClearCommand()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            CommandList.Clear();
        }
    }
}
