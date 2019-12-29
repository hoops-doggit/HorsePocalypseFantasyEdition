using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : MonoBehaviour
{
    public Camera cam;
    RaycastHit hit;
    Ray ray;
    public LayerMask layermask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDrag()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, layermask))
        {
            gameObject.transform.position = new Vector3(hit.point.x, transform.position.y , hit.point.z);
        }

       
    }
}
