using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGateCheck : MonoBehaviour
{


    public void Match()
    {
        GameObject UIGATEAND = GameObject.Find("UIGATEAND");
        if (UIGATEAND.tag == "ANDGATE") Destroy(UIGATEAND);
    }
}