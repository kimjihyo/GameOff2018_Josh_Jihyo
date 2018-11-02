using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour {

	public int mapSize;
	public Material tileColor;

	void Start() {
		GenerateMap();
	}

	void GenerateMap() {
		int offSet = mapSize - 1;
		for (int y = 0; y < mapSize; y++) {
			for (int x = 0; x < mapSize; x++) {
				GameObject tile = GameObject.CreatePrimitive(PrimitiveType.Quad);
				tile.transform.position = new Vector3(x - (offSet/2), y -(offSet/2), -1);
				tile.GetComponent<Renderer>().material = tileColor;
			}
		}
	}
}
