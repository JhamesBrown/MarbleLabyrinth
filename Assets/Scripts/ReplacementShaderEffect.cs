using UnityEngine;
using System.Collections;

public class ReplacementShaderEffect : MonoBehaviour {

	public Shader ReplacementShader;
	void OnEnable()
	{
		if (ReplacementShader != null)
			GetComponent<Camera> ().SetReplacementShader (ReplacementShader, "RenderType");
	}

	void OnDisable()
	{
		GetComponent<Camera> ().ResetReplacementShader ();
	}
}
