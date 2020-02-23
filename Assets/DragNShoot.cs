using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNShoot : MonoBehaviour
{
    public float power;
    public Rigidbody2D rig;


    Vector3 startPos, endPos;
    Vector2 force;
    [SerializeField]
    Vector2 minPower, maxPower;

    public static DragNShoot Instance;
    private void Awake()
    {
       
    }
    // Start is called before the first frame update
    void Start()
    {
        Instance = null;
        Instance = this;
        rig = GetComponent<Rigidbody2D>();
    }
    public void Shoot(Vector3 sp,Vector3 ep)
    {
        startPos = sp;
        endPos = ep;
        force = new Vector2(Mathf.Clamp(startPos.x-endPos.x,minPower.x,maxPower.x),Mathf.Clamp(startPos.y-endPos.y,minPower.y,maxPower.y));
        rig.AddForce(force*power,ForceMode2D.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
