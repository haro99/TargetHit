using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowAdd : MonoBehaviour
{
    public GameObject arrow;
    public GameObject setArrow;
    public Rigidbody setArrowrig;
    public bool set;
    public bool timeOver;
    public float waittime;
    // Start is called before the first frame update
    void Start()
    {
        set = true;
        timeOver = false;
        setArrow = Instantiate(arrow, gameObject.transform);
        setArrowrig = setArrow.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (set)
        {
            if (!timeOver &&Input.GetKeyDown(KeyCode.Space))
            {
                setArrowrig.isKinematic = false;
                setArrowrig.AddForce(setArrow.transform.forward * 20f);
                setArrow.transform.parent = null;
                set = false;
            }
 
        }
        else
        {
            waittime += Time.deltaTime;
            if (waittime > 2f)
            {
                setArrow = Instantiate(arrow, gameObject.transform);
                setArrowrig = setArrow.GetComponent<Rigidbody>();
                set = true;
                waittime = 0f;
            }
        }
    }
}
