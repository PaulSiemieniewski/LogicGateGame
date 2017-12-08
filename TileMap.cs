using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour {
	
	public GameObject selectedUnit;

	//arrays
	public TileType[] tileTypes;
	int[,] tiles;

	int mapSizeX = 10;
	int mapSizeZ = 10;

	void Start() {
		GenerateMapData ();
		GenerateMapVisuals ();
	}
		
	public void GenerateMapData() {
		// Allocate our map tiles
		tiles = new int[mapSizeX, mapSizeZ];

		int x, z;

		// Initialize our map tiles
		for (x = 0; x < mapSizeX; x++) {
			for (z = 0; z < mapSizeZ; z++) {
				tiles [x, z] = 0;
			}
		}

		// Normal tile... tile[x, z] = 0 
		// Circuit tile... tile[x, z] = 1
		// Gate tile... tile[x, z] = 2

		tiles [0, 1] = 1;
		tiles [1, 1] = 1;
		tiles [2, 1] = 1;
		tiles [3, 1] = 1;
			tiles [4, 1] = 2;

		tiles [4, 2] = 1;
		tiles [4, 3] = 1;
			tiles [4, 4] = 2;

		tiles [5, 4] = 1;
		tiles [6, 4] = 1;
		tiles [7, 4] = 1;
		tiles [8, 4] = 1;
		tiles [9, 4] = 1;

		tiles [0, 4] = 1;
		tiles [1, 4] = 1;
		tiles [2, 4] = 1;
		tiles [3, 4] = 1;




		/*
		// creating circuit tiles
		for(x = 0; x <=5; x++) {
			for(z = 0; z < 4; z++) {
				tiles[x,z] = 1;
			}
		}
		*/

		GenerateMapVisuals ();
	}
		
	// now that we have all of our map data, let's spawn a map.
	public void GenerateMapVisuals() {
		for(int x = 0; x < mapSizeX; x++) {
			for (int z = 0; z < mapSizeZ; z++) {
				TileType tt = tileTypes [tiles [x, z] ];
				GameObject go = (GameObject)Instantiate (tt.tileVisualPrefab, new Vector3 (x, 0, z), Quaternion.identity);
				ClickableTile ct = go.GetComponent<ClickableTile> ();

				ct.tileX = x;
				ct.tileZ = z;
				ct.map = this;
			}
		}
	}
		
	public Vector3 TileCoordToWorldCoord(int x, int z) {
		return new Vector3 (x, 0, z);
	}

	public void MoveSelectedUnitTo(int x, int z) {
		selectedUnit.GetComponent<Unit> ().tileX = x;
		selectedUnit.GetComponent<Unit> ().tileZ = z;
		selectedUnit.transform.position = TileCoordToWorldCoord(x, z);		
	}


}// End TileMap Class

