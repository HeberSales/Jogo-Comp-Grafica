using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TomarDano : MonoBehaviour
{
    public ThirdPersonController thirdPersonController;
    private CharacterController controller;
    Animator animator;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstaculo")
        {
            //animator.SetTrigger("death");
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //thirdPersonController.enabled = false;   
        }
        if (other.gameObject.tag == "Enemy")
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.gameObject.tag == "END")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
    // Start is called before the first frame update
   /* void Start()
    {
        
    }*/

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
