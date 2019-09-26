using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class GMngr : MonoBehaviour
{
    public bool AllApples = false;
    public bool CowFull = false;
    public int ACollect = 0;
    public int CFed = 0;
    public GameObject winText;
    Text myText;
    //public object cow;
  
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectsWithTag("apple");

    }

    public void ACount ()
    {
         ACollect = ACollect + 1;
        return;
    }

    public void OnTriggerEnter (Collider Other) {
        if (Other.gameObject.CompareTag("apple"))
        {
            CFed = CFed + 1;
            Destroy(Other.gameObject);
            return;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AllApples && CowFull)
        {
            winText.SetActive(true);
        }
    }
}
