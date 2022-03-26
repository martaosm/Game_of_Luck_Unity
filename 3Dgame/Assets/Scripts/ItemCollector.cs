using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public static int points = 0;
    public Text pointsText;
    
    void Update()
    {
        OnTriggerEnter(GetComponent<Collider>());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            Destroy(other.gameObject);
            points++;
            pointsText.text = "Points: " + points;
        }
    }
}
