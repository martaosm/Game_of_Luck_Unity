using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;
    private void OnTriggerEnter(Collider other)
    {
        GameEvents.current.doorwayTriggerEnter(id);
    }
    
    private void OnTriggerExit(Collider other)
    {
        GameEvents.current.doorwayTriggerExit(id);
    }
}
