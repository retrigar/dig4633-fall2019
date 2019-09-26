using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMngr : MonoBehaviour
{
    public bool AllApples = false;
    public bool CowFull = false;
    public int ACollect = 0;
    public int CFed = 0;
    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectsWithTag("apple");
    }

    public void ACount ()
    {

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
