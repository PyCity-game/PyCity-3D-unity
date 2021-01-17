using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public float speed = 20f;
    // Update is called once per frame
    void Update()
    {
     Vector3 pos = transform.position;
      if(Input.GetKeyUp("w")){
        pos.z += 1.3f;
      }
      if(Input.GetKeyUp("s")){
        pos.z -= 1.3f;
      }
      if(Input.GetKeyUp("a")){
        pos.x -= 1.3f;
      }
      if(Input.GetKeyUp("d")){
        pos.x += 1.3f;
      }
      transform.position = pos;

    }
}
