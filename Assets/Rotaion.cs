using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotaion : MonoBehaviour
{


    public float TireAngle = 0f;
    private const float MAX_ANGLE = 360f;
    public float TireTurnSpeed = 100f;
    

    public void Start()
    {
        
    }
    void Update()
    {
       



        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.localEulerAngles = new Vector3(0f, transform.localEulerAngles.y + (TireTurnSpeed * Time.deltaTime), 0f);
            TireAngle += TireTurnSpeed * Time.deltaTime;

        }
        else
        {
            /*if (TireAngle >= 0)
            {
                transform.localEulerAngles = new Vector3(0f, transform.localEulerAngles.y - (TireTurnSpeed * Time.deltaTime), 0f);
                TireAngle -= TireTurnSpeed * Time.deltaTime;
            }*/
        }



        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.localEulerAngles = new Vector3(0f, transform.localEulerAngles.y - (TireTurnSpeed * Time.deltaTime), 0f);
            TireAngle -= TireTurnSpeed * Time.deltaTime;

        }
        else
        {
            /*  if (TireAngle <= 0)
              {
                  transform.localEulerAngles = new Vector3(0f, transform.localEulerAngles.y + (TireTurnSpeed * Time.deltaTime), 0f);
                  TireAngle += TireTurnSpeed * Time.deltaTime;
              }*/
        }
    }

}
