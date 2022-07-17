using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CharacterMovement : MonoBehaviour
{
    public Tilemap tilemap;
    private Vector3Int gridPosition;


    void Start()
    {
        gridPosition = new Vector3Int(0, 0, 0);
       
    }

    
    void Update()
    {
        transform.position = tilemap.WorldToCell(gridPosition);

        if (Input.GetKeyDown(KeyCode.W))
        {
            gridPosition.y += 1;
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            gridPosition.y -= 1;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            gridPosition.x -= 1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            gridPosition.x += 1;
        }
    }
}
