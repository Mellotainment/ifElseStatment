using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public int playerX, playerZ;
	public GameObject textObject;

	// Use this for initialization
	void Start () {
	
		playerX = 0;
		playerZ = 0;

		transform.position= new Vector3 (playerX, 0, playerZ);

		textObject.GetComponent<TextMesh> ().text = "mello";

	}
	
	// Update is called once per frame
	void Update () {

		playerZ = (int)transform.position.z; 
		playerX = (int)transform.position.x; 

		if (Input.GetKeyDown (KeyCode.UpArrow)){
			transform.position += new Vector3 (0, 0, 1);


		if (Input.GetKeyDown (KeyCode.DownArrow))
			transform.position += new Vector3 (0, 0, -1);

		if (Input.GetKeyDown (KeyCode.LeftArrow))
			transform.position += new Vector3 (-1, 0, 0);

		if (Input.GetKeyDown (KeyCode.RightArrow))
			transform.position += new Vector3 (1, 0, 0);
	}


		textObject.GetComponent<TextMesh> ().text = "Position: (" + transform.position.x + "," +
		playerZ + ")";
		
		if (playerX == 0&& playerZ == 2){ Debug.Log ("reset the play's position");
	
	}
}
}
