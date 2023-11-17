using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TirGauche : MonoBehaviour
{
    public GameObject BalleEntrer;
    public GameObject BalleSortie;
    public float launchVelocity = 700f;
    public float angle;
    private float angleforce;
    private float forcex;
    private float forcey;

    void Update()
    {
        if (Input.GetButtonDown("LeftMouseClick"))
        {
            GameObject ball = Instantiate(BalleEntrer, transform.position,
                                                      transform.rotation);
            if (angle >= 0 && angle <= 90) 
            {
                forcex = (90 - angle) / 90;
                forcey = angle / 90;
            } else if (angle > 90 && angle <= 180)
            {
                forcex = -1 * (angle - 90) / 90;
                forcey = (90 - (angle - 90)) / 90;
            } else if (angle > 180 && angle <= 270)
            {
                forcex = -1 * (90 - (angle - 180)) / 90;
                forcey = -1 * (angle - 180) / 90;
            } else if (angle > 270 && angle <= 360)
            {
                forcex = (angle - 270) / 90;
                forcey = -1 * (90 - (angle - 270)) / 90;
            }
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3
                                                 (forcex * launchVelocity, forcey * launchVelocity, 0));
        } else if (Input.GetButtonDown("RightMouseClick")) 
        {
            GameObject ball = Instantiate(BalleSortie, transform.position,
                                          transform.rotation);
            if (angle >= 0 && angle <= 90)
            {
                forcex = (90 - angle) / 90;
                forcey = angle / 90;
            }
            else if (angle > 90 && angle <= 180)
            {
                forcex = -1 * (angle - 90) / 90;
                forcey = (90 - (angle - 90)) / 90;
            }
            else if (angle > 180 && angle <= 270)
            {
                forcex = -1 * (90 - (angle - 180)) / 90;
                forcey = -1 * (angle - 180) / 90;
            }
            else if (angle > 270 && angle <= 360)
            {
                forcex = (angle - 270) / 90;
                forcey = -1 * (90 - (angle - 270)) / 90;
            }
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3
                                                 (forcex * launchVelocity, forcey * launchVelocity, 0));
        }
    }
}
