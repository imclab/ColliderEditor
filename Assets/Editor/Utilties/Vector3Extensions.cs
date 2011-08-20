using UnityEngine;
using System.Collections;

public static class Vector3Extensions {
	
	public static float LargestComponent (this Vector3 v)
	{
		// Find the largest vector component with ternary insanity
		return v.x > v.y ? (v.x > v.z ? v.x : (v.y > v.z ? v.y : v.z)) : (v.y > v.z ? v.y : (v.x > v.z ? v.x : v.z));
	}
		
	public static Vector3 MultiplyComponents (this Vector3 a, Vector3 b)
	{
		return new Vector3 (a.x * b.x, a.y * b.y, a.z * b.z);
	}
	
}
