using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
  public GameObject houseOriginal;
  public GameObject selecet;
  public CanvasGroup ui;
  //public CanvasGroup ui2;
  public CanvasGroup ui3;
  public int istrue = 0;
  public float speed = 20f;


    // Start is called before the first frame update
    void Start()
    {
      selecet.GetComponent<Renderer>().enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
      if(istrue==1){
        ui.alpha = 1f;
        ui.blocksRaycasts = false;
        //ui2.alpha = 1f;
        //ui2.blocksRaycasts = false;

        ui3.alpha = 1f;
        ui3.blocksRaycasts = false;
        selecet.GetComponent<Renderer>().enabled=true;
      }
      if (Input.GetKeyUp(KeyCode.Return) && istrue==1){
        GameObject HouseClone = Instantiate(houseOriginal, selecet.transform.position, houseOriginal.transform.rotation);
      }
      if (istrue==0){
        istrue=0;
        ui.alpha = 0f;
        ui.blocksRaycasts = true;
        //ui2.alpha = 0f;
        //ui2.blocksRaycasts = true;
        ui3.alpha = 0f;
        ui3.blocksRaycasts = true;
        selecet.GetComponent<Renderer>().enabled=false;
      }


      }

    public void onClick(int value){
        istrue=value;
    }


}
