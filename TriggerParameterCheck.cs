using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerParameterCheck : MonoBehaviour
{
    [SerializeField]
    private Image CustomImage;

    void Start()
    {
        CustomImage.enabled = true;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Gate"))
        {
           
                CustomImage.enabled = true;

            }
        }
    }
