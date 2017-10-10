using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class teste : MonoBehaviour , IDragHandler, IBeginDragHandler, IEndDragHandler {

	public GameObject itemDrag;
	Vector3 startPosition;
	private Vector3 screenPoint;

	#region IBeginDragHandler implementation
	public void OnBeginDrag (PointerEventData eventData)
	{
		itemDrag = gameObject;
		startPosition = transform.position;

	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		screenPoint = Input.mousePosition;
		screenPoint.z = 1f; //distance of the plane from the camera
		transform.position = Camera.main.ScreenToWorldPoint(screenPoint);



	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		itemDrag = null;
		transform.position = startPosition;

	}

	#endregion
}
