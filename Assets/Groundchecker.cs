using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class Groundchecker : MonoBehaviour {

    public bool onground;
    public Tilemap tilemap;
    public Tile ground;
    public Transform[] points;
    private void Update()
    {
        onground = false;
        foreach(Transform point in points)
        {
            if(tilemap.GetTile(tilemap.WorldToCell(point.position)) == ground)
            {
                onground = true;
            }
        }
    }
}
