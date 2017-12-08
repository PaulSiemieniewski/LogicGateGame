using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerCollision : MonoBehaviour
{

    [SerializeField]
    public Image customImage;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "ANDGATE")
        { customImage.enabled = true; }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "ANDGATE")
        { customImage.enabled = false; }
    }
}
