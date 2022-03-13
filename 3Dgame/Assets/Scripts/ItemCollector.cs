using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int points = 0;

    // Update is called once per frame
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
            Debug.Log(points);
        }
    }
}
