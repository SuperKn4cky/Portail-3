using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPortailEntrer : MonoBehaviour
{
    public GameObject Portail;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (other.CompareTag("Est"))
        {
            if (GameObject.Find("PortailEntrer(Clone)"))
            {
                Destroy(GameObject.Find("PortailEntrer(Clone)").gameObject);
            }
            GameObject Portail1 = Instantiate(Portail, transform.position,
                                     transform.rotation);

            Portail1.transform.position = new Vector3(Portail1.transform.position.x + (float)0.1, Portail1.transform.position.y, Portail1.transform.position.z);
            Portail1.transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
            TpVelocitySortie.Entrer = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
