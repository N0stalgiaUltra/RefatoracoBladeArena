using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class LimitesTeleport : MonoBehaviour
{

    [SerializeField] private GameObject limitsParent;
    private Transform leftEnd;
    private Transform rightEnd;

    private void Start()
    {
        leftEnd = limitsParent.transform.GetChild(0).transform;
        rightEnd = limitsParent.transform.GetChild(1).transform;
    }


    void Update()
    {
       
        if(this.transform.position.x > rightEnd.position.x)
        {
            this.transform.position = new Vector2(leftEnd.position.x, this.transform.position.y);
        }
        else if(this.transform.position.x < leftEnd.position.x)
        {
            this.transform.position = new Vector2(rightEnd.position.x, this.transform.position.y);
        }
    }


}
