using UnityEngine;
using System.Collections;

public class CollisionTest : MonoBehaviour {

	public Color lineColor  = new Color(1, 0, 0, 1f);
	public Color triColor  = new Color(1, 1, 0, 1f);

	public Line line;
	public Triangle Triangle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}


	void OnDrawGizmos() 
	{
		// Draw Line
		Gizmos.color = lineColor;
		Gizmos.DrawLine(line.p0.transform.position, line.p1.transform.position);
	}

	public bool Intersect(Vector3 p1, Vector3 p2, Vector3 p3, Line ray, ref Vector3 hit)
	{

		// Vectors from p1 to p2/p3 (edges)
		//Find vectors for edges sharing vertex/point p1
		Vector3 e1 = p2 - p1;
		Vector3 e2 = p3 - p1;

		// Calculate determinant
		Vector3 p = Vector3.Cross(ray.direction, e2);

		//Calculate determinat
		float det = Vector3.Dot(e1, p);

		//if determinant is near zero, ray lies in plane of triangle otherwise not
		if (det > -Mathf.Epsilon && det < Mathf.Epsilon) { return false; }
		float invDet = 1.0f / det;

		//calculate distance from p1 to ray origin
		Vector3 t = ray.origin - p1;

		//Calculate u parameter
		float u = Vector3.Dot(t, p) * invDet;

		//Check for ray hit
		if (u < 0 || u > 1) { return false; }

		//Prepare to test v parameter
		Vector3 q = Vector3.Cross(t, e1);

		//Calculate v parameter
		float v = Vector3.Dot(ray.direction, q) * invDet;

		//Check for ray hit
		if (v < 0 || u + v > 1) { return false; }

		// intersection point
		hit  = p1 + u*e1 + v*e2;

		if ((Vector3.Dot(e2, q) * invDet) > Mathf.Epsilon){
			//ray does intersect
			return true;
		}

		// No hit at all
		return false;
	}


}
