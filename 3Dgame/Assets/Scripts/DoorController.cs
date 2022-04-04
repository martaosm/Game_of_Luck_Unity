using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int id;

    void Start()
    {
        GameEvents.current.onDoorwayTriggerEnter += onDoorwayOpen;
        GameEvents.current.onDoorwayTriggerExit += onDoorwayClose;
    }

    private void onDoorwayClose(int id)
    {
        if (id == this.id)
        {

            LeanTween.moveLocalY(gameObject, 1.5f, 1f).setEaseInQuad();
        }

    }

    private void onDoorwayOpen(int id)
    {
        if (id == this.id)
        {
            if (id == 1)
            {
                if (ItemCollector.points > 4 )
                {
                    LeanTween.moveLocalY(gameObject, 5f, 1f).setEaseOutQuad();
                }
                else
                {
                    return;
                }
            }
            else
            {
                LeanTween.moveLocalY(gameObject, 5f, 1f).setEaseOutQuad();
            }

        }
    }
}
