using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {

	public GameObject [] SortingWall;


	public GameObject blankWall; 
	public GameObject nickWall;

	public bool canSpawnShapes;


	public int randomWallSelectionIndex;


	public SpawnManager spawnManager;



	// Use this for initialization
	void Start () {
		canSpawnShapes = false;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Spawner(){

		if(canSpawnShapes){

			ShapeWallSpawn ();
		}
		else if(!canSpawnShapes){

			SolidWallSpawn ();

		}


	}



	public void ShapeWallSpawn ()
	{

		randomWallSelectionIndex = Random.Range(0, 11);
		Instantiate (SortingWall [randomWallSelectionIndex], transform.position, transform.rotation );
	}



	public void SolidWallSpawn()
	{
		if(spawnManager.totalCollisions <= 30){
			Instantiate (blankWall, transform.position, transform.rotation);
			
		}
		else if(spawnManager.totalCollisions > 30){

			Instantiate(nickWall, transform.position, transform.rotation);
		}

	}
}
