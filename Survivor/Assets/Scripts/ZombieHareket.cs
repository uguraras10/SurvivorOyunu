using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieHareket : MonoBehaviour
{
    private GameObject oyuncu;
    private int zombieCan = 3;
    // Start is called before the first frame update
    void Start()
    {
        oyuncu = GameObject.Find("Oyuncu");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = oyuncu.transform.position;
    }
    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.gameObject.tag.Equals("mermi")){

            Debug.Log("Çarpışma Gerçekleşti.");
            zombieCan--;
            if (zombieCan<1)
            {
                GetComponentInChildren<Animation>().Play("Zombie_Death_01");
                Destroy(this.gameObject, 1.667f);

            }
        }
        
    }
}
