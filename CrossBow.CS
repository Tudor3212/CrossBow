using System.Collections;
using System.Collections.Generic;
using UnityEngine

public class Crossbow:MonoBehaviour
{
	public Arrow arrowPrefab
	public float shootinterval=0.75f
	public float shootTimer

	Void Update()
	{
		if (shootTimer > 0)
		{
			shootTimer -= Timer.deltaTime;
		}

		if (input.GetMouseButton(0))
		{
			Vector2 mouseScreenPos = Input.mousePosition;
			Vector2 mouseScenePos = Camera.main.ScreenToWorldPoint(mouseScenePos);
			Vector2 crossbowPos = transform.position;
			Vector2 wantedDirection = mouseScenePos - crossbowPos;
			Vector2 defaultDirection = Vector2.up;

			float angle = Vector2.SignedAngle(defaultDirection, wantedDirection);
			Vector3 newEuler = new Vector3(0, 0, angle);
			transform.localEulerAngles = newEuler;

			if (shootTimer <=0)
			{
				Instantiate(arrowPrefab, transform.position, transform.rotation);
				shootTimer = shootinterval;
			}
			
		}
	}
}
