using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour {

	public Color color  = new Color(1, 0, 0, 1f);
	public Color colorSelected  = new Color(1, 1, 1, 1f);

	void OnDrawGizmos() {
		Gizmos.color = color;
		Gizmos.DrawCube(transform.position, new Vector3(0.25f, 0.25f, 0.25f));
	}

	void OnDrawGizmosSelected() {
		Gizmos.color = colorSelected;
		Gizmos.DrawCube(transform.position, new Vector3(0.25f, 0.25f, 0.25f));
	}

}