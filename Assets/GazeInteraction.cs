using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChestAnimation : MonoBehaviour {

    public float gazeTime = 2f;
    private float timer;
    private bool gazedAt;

    public bool on = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //if (gazedAt)
        //{
            //timer += Time.deltaTime;

            //if (timer >= gazeTime)
            //{
                // execute pointerdown handler
                //ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                //timer = 0f;
            //}
        }

  
    private void OnTriggerStay(Collider other)
    {
        Animation anim = other.GetComponent<Animation>();
        if(gazedAt)
        {
            timer += Time.deltaTime;

            if (timer >= gazeTime)
            {

                if (on)
                {
                    anim.Play("Open_Chest");
                    on = false;
                }
                if(!on)
                {
                    anim.Play("Close_Chest");
                    on = true;
                }
            }
        }
    }
  
    public void PointerEnter()
    {
        gazedAt = true;
        Debug.Log("PointerEnter");
    }

    public void PointerExit()
    {
        gazedAt = false;
        Debug.Log("PointerExit");
    }

    public void PointerDown()
    {
        Debug.Log("PointerDown");
    }

	
}
