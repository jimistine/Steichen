using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCircle : MonoBehaviour {

	
	List<GameObject> prefabList = new List<GameObject>();
	public GameObject pointPrefab_1;                    //generic prefab to place on each point
	public GameObject pointPrefab_2;
	public GameObject pointPrefab_3;
	public GameObject pointPrefab_4;
	public GameObject pointPrefab_5;
	public GameObject pointPrefab_6;
	
	public int numPoints = 20;                        //number of points on radius to place prefabs
	public Vector3 centerPos = new Vector3(0,0,32);    //center of circle/elipsoid
 
	public float radiusX,radiusY;                    //radii for each x,y axes, respectively
 
	public bool isCircular = true;                    //is the drawn shape a complete circle?
	public bool vertical = false;                    //is the drawb shape on the xy-plane?
 
	Vector3 pointPos;                                //position to place each prefab along the given circle/eliptoid
	//*is set during each iteration of the loop
 
	// Use this for initialization
	void Start () {
		
		prefabList.Add(pointPrefab_1);
		prefabList.Add(pointPrefab_2);
		prefabList.Add(pointPrefab_3);
		prefabList.Add(pointPrefab_4);
		prefabList.Add(pointPrefab_5);
		prefabList.Add(pointPrefab_6);
		
		for(int i = 0; i<numPoints;i++){
			//multiply 'i' by '1.0f' to ensure the result is a fraction
			float pointNum = (i*1.0f)/numPoints;
 
			//angle along the unit circle for placing points
			float angle = pointNum*Mathf.PI*2;
 
			float x = Mathf.Sin (angle)*radiusX;
			float y = Mathf.Cos (angle)*radiusY;
 
			//position for the point prefab
			if(vertical)
				pointPos = new Vector3(x, y)+centerPos;
			else if (!vertical){
				pointPos = new Vector3(x, 0, y)+centerPos;
			}
 
			//place the prefab at given position
			int prefabIndex = Random.Range(0,5);
			Instantiate (prefabList[prefabIndex], pointPos, Quaternion.identity);
		}
 
		//keeps radius on both axes the same if circular
		if(isCircular){
			radiusY = radiusX;
		}
	}
}
