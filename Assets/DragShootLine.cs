using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragShootLine : MonoBehaviour
{
    [SerializeField]
    LineRenderer line;
    public Vector3 startPos, endPos;
    private void Awake()
    {
        line = GetComponent<LineRenderer>();
        line.SetPosition(0,Vector3.zero);
        line.SetPosition(1,Vector3.zero);
        line.numCapVertices = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DragNShoot.Instance.rig.velocity = Vector3.zero;
            line.numCapVertices = 90;
            startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 newstartPos = new Vector3(startPos.x,startPos.y,0);
            line.SetPosition(1, newstartPos);
            line.SetPosition(0, newstartPos);
        }
        else if(Input.GetMouseButton(0))
        {
            DragNShoot.Instance.rig.velocity = Vector3.zero;
            endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 newendPos = new Vector3(endPos.x,endPos.y,0);
            line.SetPosition(0,newendPos);
        }else if(Input.GetMouseButtonUp(0))
        {
            line.SetPosition(0, Vector3.zero);
            line.SetPosition(1, Vector3.zero);
            line.numCapVertices = 0;
            DragNShoot.Instance.Shoot(startPos,endPos);
        }
    }
}
