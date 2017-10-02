using UnityEngine;
using System.Collections;

public class Line : MonoBehaviour {


	public Point p0;
	public Point p1;

	public Vector3 origin
	{
		get { return p0.transform.position; }
	}

	public Vector3 direction
	{
		get { return (p1.transform.position - p0.transform.position).normalized; }
	}





}