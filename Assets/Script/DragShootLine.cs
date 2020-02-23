using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragShootLine : MonoBehaviour
{
    [SerializeField]
    LineRenderer line;
    public Vector3 startPos, endPos;
    Vector3 intialValue;
    bool drag;
    private void Awake()
    {
       // line = GetComponent<LineRenderer>();

        
    }
    // Start is called before the first frame update
    void Start()
    {
        line.SetPosition(0, Vector3.zero);
        line.SetPosition(1, Vector3.zero);
        line.numCapVertices = 0;
    }
    //private void OnMouseDown()
    //{
    //    DragNShoot.Instance.rig.velocity = Vector3.zero;
    //    line.numCapVertices = 90;
    //    startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    Vector3 newstartPos = new Vector3(this.transform.position.x, this.transform.position.y, 0);
    //    line.SetPosition(1, newstartPos);
    //    line.SetPosition(0, newstartPos);
    //    drag = true;
    //}
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            DragNShoot.Instance.rig.velocity = Vector3.zero;
            line.numCapVertices = 90;
            startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 newPos = startPos;
            Vector3 newstartPos = new Vector3(this.transform.position.x, this.transform.position.y, 0);
            line.SetPosition(1, newPos);
            line.SetPosition(0, newstartPos);
            drag = true;
        }
        if(drag)
        {
            DragNShoot.Instance.rig.velocity = Vector3.zero;
            endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 newendPos = new Vector3(endPos.x,endPos.y,0);
            line.SetPosition(0,newendPos);
            line.SetPosition(1,new Vector3(this.transform.position.x, this.transform.position.y, 0));
        }
        if(Input.GetMouseButtonUp(0))
        {
            drag = false;
            intialValue = new Vector3(this.transform.position.x, this.transform.position.y, 0);
            line.SetPosition(0, Vector3.zero);
            line.SetPosition(1, Vector3.zero);
            line.numCapVertices = 0;
            DragNShoot.Instance.Shoot(endPos, intialValue);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(enabled==true)
       GameSounds.Instance.PlayJumpSound(1);
    }
    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    DragNShoot.Instance.rig.velocity = Vector3.zero;
    //    line.numCapVertices = 90;
    //    startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    Vector3 newstartPos = new Vector3(this.transform.position.x, this.transform.position.y, 0);
    //    line.SetPosition(1, newstartPos);
    //    line.SetPosition(0, newstartPos);
    //    drag = true;
    //}
    private void OnMouseUp()
    {
        
    }
    //public void OnPointerUp(PointerEventData eventData)
    //{
    //    drag = false;
    //    line.SetPosition(0, Vector3.zero);
    //    line.SetPosition(1, Vector3.zero);
    //    line.numCapVertices = 0;
    //    DragNShoot.Instance.Shoot(startPos, endPos);
    //}
}
