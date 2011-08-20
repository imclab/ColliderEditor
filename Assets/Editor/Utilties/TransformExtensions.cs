using UnityEngine;
using System.Collections;

public static class TransformExtensions {
	
	// Apply a transformation resembling a parenting relationship without setting up an actual parenting hierarchy
	public static void SoftParent (this Transform child, Transform parent)
	{
		Vector3 offset = child.position - parent.position;
		Vector3 scale = parent.localScale;
		
		// TRS
		child.position = parent.rotation * offset.MultiplyComponents (scale) + parent.position;
		child.rotation = parent.rotation; // FIXME need to add the original rotation
		child.localScale = child.localScale.MultiplyComponents(parent.localScale);
	}
	
}
