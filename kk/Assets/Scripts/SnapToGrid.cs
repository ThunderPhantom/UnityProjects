using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SnapToGrid : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Grid grid = FindObjectOfType<Grid>(); //gets the grid layout
        Vector3Int cellPos = grid.LocalToCell(transform.localPosition); //gets the objects location and aligns it in a cell
        transform.localPosition = grid.GetCellCenterLocal(cellPos); //sets the position of the gameobject to the center of the grid cell
	}
	
}
