using UnityEngine;
using System.Collections;

public class Controllerscene2 : MonoBehaviour {
	
	public static Cube [,] gridOfCubes;
	private int gridWidth, gridHeight;
	float timer = 0;
		
	void SetCubeColor(GameObject Cube)
	{
		//Cube.cubeColor = Random.Range (1, 5);
	}
	// Use this for initialization
	void Start () {
		gridWidth = 8;
		gridHeight = 5;
		
		gridOfCubes = new Cube[gridWidth,gridHeight];
		
	//create an 8x5 grid of cubes
		for (int x=0; x< gridWidth; x++){
			for (int y=0; y<gridHeight; y++){
				gridOfCubes [x,y] = new Cube((GameObject)Instantiate (Resources.Load ("cube"), new Vector3 (x*2, y*2,5), Quaternion.identity));
				gridOfCubes [x,y].SetColor(Color.white);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown (0))
		{
		}
		
	
		timer += Time.deltaTime;
		if (timer >= 2.5)
		{
			print (timer);
			timer = 0;
			Cube.setRandomColor();
		}
		
	
	}
}
