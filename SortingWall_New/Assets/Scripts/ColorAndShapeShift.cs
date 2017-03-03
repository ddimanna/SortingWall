using UnityEngine;
using System.Collections;

public class ColorAndShapeShift : MonoBehaviour {
	//3 available shapes
	//red blue green yellow
	//use a loop to go through the array
	//pull active color and shape, if correct deactivate collider on wall
	public GameObject playerPrefab;
	public GameObject cubeBody;
	public GameObject sphereBody;
	public GameObject triangleBody;

	public GameObject [] availableShapes;
	public Material [] availableMaterials;

	public GameObject activeShape;
	public Material activeMaterial;
	public MeshRenderer renderer;

	public MeshRenderer cubeRenderer;
	public MeshRenderer sphereRenderer;
	public MeshRenderer triangleRenderer;






//	public Material assignableMaterial;
//	public GameObject assignableShape;

	//public Material materialOnActiveShape;

	int shapeIndex = 0;
	int materialIndex = 0;

	// Use this for initialization
	void Start () {

//		assignableShape = availableShapes[shapeIndex];
//		assignableMaterial = availableMaterials[materialIndex];
//
//
//		activeMaterial = assignableMaterial;//activeShape.GetComponent<Material>();
//		activeShape = assignableShape;
//
//		shapeIndex = 0;
//
//		SetActiveShape();
//
//		materialOnActiveShape = activeShape.GetComponent<Material>(); //= activeMaterial;
//
//		activeMaterial = materialOnActiveShape;


		activeShape = availableShapes[shapeIndex];
		activeMaterial = availableMaterials[materialIndex];

		cubeRenderer = cubeBody.GetComponent<MeshRenderer>();
		sphereRenderer = sphereBody.GetComponent<MeshRenderer>();
		triangleRenderer = triangleBody.GetComponent<MeshRenderer>();


		//playerPrefab.GetComponentsInChildren


		SetActiveShape();
		SetActiveMaterial();
	
	}
	
	// Update is called once per frame
	void Update () {

		//activeShape = assignableShape;
		//activeMaterial = assignableMaterial;

		if(shapeIndex > 2){

			shapeIndex = 0;
		}

		if(materialIndex > 3){

			materialIndex = 0;
		}

		if(Input.GetKeyDown(KeyCode.S)){

			SetActiveShape();
		}
		if(Input.GetKeyDown(KeyCode.W)){

			SetActiveMaterial();
		}
	
	}

	void SetActiveShape(){

		activeShape = availableShapes[shapeIndex];

		if(activeShape == availableShapes[0]){

			cubeBody.SetActive(true);
			sphereBody.SetActive(false);
			triangleBody.SetActive(false);

		}
		else if(activeShape == availableShapes[1]){

			cubeBody.SetActive(false);
			sphereBody.SetActive(true);
			triangleBody.SetActive(false);

		}
		else if(activeShape == availableShapes[2]){

			cubeBody.SetActive(false);
			sphereBody.SetActive(false);
			triangleBody.SetActive(true);

		}

	
			
		//activeShape = availableShapes[shapeIndex];
			

		shapeIndex++;
	}


	void SetActiveMaterial(){
		
		activeMaterial = availableMaterials[materialIndex];

		cubeRenderer.material = activeMaterial;

		sphereRenderer.material = activeMaterial;

		triangleRenderer.material = activeMaterial;



			
		materialIndex++;
	}
		
}
