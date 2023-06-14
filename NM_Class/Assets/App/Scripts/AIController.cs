using UnityEngine;
using UnityEngine.AI;
public class AIController : MonoBehaviour
{
    private Camera cam;
    private NavMeshAgent agent;
    void Start()
    {
        cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }   
    }
}