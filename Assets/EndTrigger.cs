using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name=="Player")
        {
            StartCoroutine(WaitForDelay(collision));
        }
    }
    IEnumerator WaitForDelay(Collider2D collision)
    {
        DragNShoot.Instance.rig.velocity = Vector3.zero;
        collision.GetComponent<DragNShoot>().enabled = false;
        collision.GetComponent<DragShootLine>().enabled = false;
        yield return new WaitForSeconds(2f);
        GameController.controller.LoadGameObject(2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
