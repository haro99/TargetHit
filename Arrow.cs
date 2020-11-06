using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Rigidbody arrowrig;
    public GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        arrowrig = gameObject.GetComponent<Rigidbody>();
        score = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.y < -20f)
        {
            Destroy(this.gameObject);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        arrowrig.useGravity = true;
        arrowrig.isKinematic = true;
        gameObject.GetComponent<BoxCollider>().isTrigger = true;
        collision.gameObject.GetComponent<MeshCollider>().isTrigger = true;
        Destroy(this.gameObject, 2f);
        Destroy(collision.gameObject, 2f);
        score.GetComponent<Score>().scoreAdd();
    }
}
