using UnityEngine;
using System.Collections;

public class Cube {
	int cubeColor;
	GameObject newCube;
	bool scored;
	bool isActive;

	public Cube (GameObject incomingCube) {
		newCube = incomingCube;
		isActive = false;
		scored = false;
	}
	
	public void SetColor (Color newColor) {
		newCube.renderer.material.color = newColor;	
	}
	public void Score()
	{
		scored = true;
		newCube.renderer.material.color = Color.gray;
		isActive = false;
	}
	public void Activate()
	{
		isActive = true;
	}
	public static void setRandomColor()//GameObject cubeToChange)
	{
		int integer;
		integer = Random.Range (1, 5);
		Debug.Log("integer");
	}
	public void OnMouseDown(GameObject incomingCube)
	{
    }


}
	

