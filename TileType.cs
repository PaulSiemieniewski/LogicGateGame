using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // add this so TileType[] in the TileMap.cs file will appear in the Inspector

public class TileType { // remove Monobehavior because this script is not attached to an object.

	public string name;
	public GameObject tileVisualPrefab;

}
