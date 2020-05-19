using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChestAnim : MonoBehaviour
{

    public float gazeTime = 2f;
    private float timer;
    private bool gazedAt;
    public Animation anim;

    public bool on = true;
   
    enum Status
    {
        Open, Closed
    };
    


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (gazedAt)
        {
            timer += Time.deltaTime;

            if (timer >= gazeTime)
            {
                // execute pointerdown handler
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
            }
        }
    }


    private void OnTriggerStay(Collider other)
    {
        //Animation anim = other.GetComponent<Animation>();
        anim = GetComponentInChildren<Animation>();
        if (gazedAt)
        {
            timer += Time.deltaTime;

            if (timer >= gazeTime)
            {

                if (gazedAt && on)
                {
                    anim.Play("Close_Chest");
                    ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                    timer = 0f;
                    on = false;
                }
                if (gazedAt && !on)
                {
                    anim.Play("Open_Chest");
                    ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                    timer = 0f;
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
        anim = GetComponent<Animation>();
        if (gazedAt)
        {
            timer += Time.deltaTime;

            if (timer >= gazeTime)
            {

                if (gazedAt && on)
                {
                    anim.Play("Close_Chest");
                    ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                    timer = 0f;
                    on = false;
                }
                if (gazedAt && !on)
                {
                    anim.Play("Open_Chest");
                    ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                    timer = 0f;
                    on = true;
                }
            }
        }
    }


}
