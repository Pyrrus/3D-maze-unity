using UnityEngine;
using System.Collections;

public class Maze : MonoBehaviour {

    public GameObject wall;
    public float wallLength = 1.0f;
    public int xsize = 5;
    public int ysize = 5;
    private Vector3 initialPos;
    private GameObject wallHolder;
    
	// Use this for initialization
	void Start () {
        CreateWalls();
	}

    void CreateWalls() {
        wallHolder = new GameObject();
        wallHolder.name = "Maze";
    
        initialPos = new Vector3((-xsize / 2) + wallLength / 2, 0.0f, (-ysize / 2) + wallLength / 2);
        Vector3 myPos = initialPos;
        GameObject tempWall;
        // x axis
        for (int i = 0; i < ysize; i++)
        {
            for (int j = 0; j <= xsize; j++)
            {
                myPos = new Vector3(initialPos.x + (j * wallLength) - wallLength/2, 0.0f, initialPos.z + (i*wallLength) -wallLength/2);
                tempWall = Instantiate(wall, myPos, Quaternion.identity) as GameObject;
                tempWall.transform.parent = wallHolder.transform;
            }
        }

        // y axis
        for (int i = 0; i <= ysize; i++)
        {
            for (int j = 0; j < xsize; j++)
            {
               myPos = new Vector3(initialPos.x + (j * wallLength), 0.0f, initialPos.z + (i * wallLength) - wallLength);
               tempWall = Instantiate(wall, myPos, Quaternion.Euler(0.0f, 90.0f, 0.0f)) as GameObject;
               tempWall.transform.parent = wallHolder.transform;
            }
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
