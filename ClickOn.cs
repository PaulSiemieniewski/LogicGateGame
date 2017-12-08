using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour {
    // THIS SCRIPT ALLOWS FOR A MESHREND TO CHANGE FROM ONE TEXTURE TO ANOTHER USING 3D TILES. CHANGE MATERIALS FOR DIFFERENT TEXTURE RESULTS
    [SerializeField]
    private Material MatGateAnd;
    [SerializeField]
    private Material MatGate;

    private MeshRenderer myRend;

	// Use this for initialization
	void Start () {
        myRend = GetComponent<MeshRenderer>();
	}
	
	public void ClickMe()
    { 
           myRend.material = MatGate;
}
    }
