// @file MoveImage.cs
// @author Okada Moeto

using UnityEngine;
using System.Collections;

public class MoveImage : MonoBehaviour
{
	Rigidbody2D rigidbody2D = null;
	public Rigidbody2D RigidBody
	{
		get
		{
			return rigidbody2D ?? (rigidbody2D = gameObject.GetComponent<Rigidbody2D> ());
		}
	}

	public static float CosFromDeg(float Deg)
	{
		return Mathf.Cos(Mathf.Deg2Rad * Deg);
	}
	
	public static float SinFromDeg(float Deg)
	{
		return Mathf.Sin(Mathf.Deg2Rad * Deg);
	}

	void SetVelocity (float direction, float speed)
	{
		Vector2 v;
		v.x = CosFromDeg (direction) * speed;
		v.y = SinFromDeg (direction) * speed;
		RigidBody.velocity = v;
	}
	
	void Start()
	{
		SetVelocity(45.0f, 5.0f * 100.0f);
	}
}
