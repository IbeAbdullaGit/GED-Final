using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghosts : MonoBehaviour
{
    public bool ObjectPooling = false;
    public GameObject prefab;
    public int size = 0;
    GameObject currentObj;

    private void Awake()
    {
        if (ObjectPooling && size < 3 )
        {
            ObjectPooler.instance.SpawnFromPool("Ghost", new Vector3(0f, 0f, 0f), new Quaternion(0f, 0f, 0f, 0f));
            size++;
        }
        else
        {
            currentObj = Instantiate(prefab);
        }
    }
    private void OnEnable()
    {
        transform.GetComponent<Rigidbody>().WakeUp();
    }

    private void OnDisable()
    {
        transform.GetComponent<Rigidbody>().Sleep();
    }

    private void OnCollisionEnter(Collision other)
    {
        //With object pooling
        gameObject.SetActive(false);

        if(other.collider.tag == "Play")
        {

        }
    }
}
