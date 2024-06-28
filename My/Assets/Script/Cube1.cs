using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour
{
    public GameObject targetObject; 
    public float speed; 
    public float stoppingDistance = 0.1f; 

    private List<Vector3> movementPoints = new List<Vector3>(); 

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RecordMovementPoint();
        }

        
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            movementPoints.Clear(); 
        }
        else
        {
            MoveTowardsPoints(); 
        }
    }

    void RecordMovementPoint()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            movementPoints.Add(new Vector3(hit.point.x, targetObject.transform.position.y, hit.point.z)); // Добавляем точку в список, сохраняя высоту объекта
        }
    }

    void MoveTowardsPoints()
    {
        if (movementPoints.Count > 0)
        {
           
            targetObject.transform.position = Vector3.MoveTowards(
                targetObject.transform.position,
                movementPoints[0],
                speed * Time.deltaTime
            );

            
            if (Vector3.Distance(targetObject.transform.position, movementPoints[0]) < stoppingDistance)
            {
                movementPoints.RemoveAt(0);
            }
        }
    }
}
