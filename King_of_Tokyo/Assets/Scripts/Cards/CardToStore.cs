using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardToStore : MonoBehaviour
{
    public GameObject store;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        store = GameObject.Find("Store");
        prefab.transform.SetParent(store.transform);
        prefab.transform.localScale = Vector3.one;
        prefab.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        prefab.transform.eulerAngles = new Vector3(25, 0, 0);        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
