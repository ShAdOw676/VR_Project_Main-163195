using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Grab : MonoBehaviour
{

    public GameObject barrel;
    public GameObject myHand;
    bool inHands = false;
    Vector3 barrelPos;
    public Image imgCircle;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer = 0;
    public bool GrabTheBarrel { get; set; }

    // Use this for initialization
    void Start()
    {
        barrelPos = barrel.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }

        if (gvrTimer > totalTime)
        {
            GVRClick.Invoke();
            GrabTheBarrel = true;
            GvrOff();
        }

        if (GrabTheBarrel && !inHands)
        {
            barrel.transform.SetParent(myHand.transform);
            barrel.transform.localPosition = new Vector3(0f, -.672f, 0f);
            inHands = true;
        }
        else if (inHands)
        {
            this.GetComponent<Grab>().enabled = false;
            barrel.transform.SetParent(null);
            barrel.transform.localPosition = barrelPos;
            inHands = false;
        }

    }

    public void GvrOn()
    {
        gvrStatus = true;
    }

    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
    }
}
