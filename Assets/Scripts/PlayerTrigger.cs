using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mainController;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      //When the Primitive collides with the walls, it will reverse direction
    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "sound_trigger"){
       		other.GetComponent<SoundTrigger>().playSound();
          mainController.GetComponent<Main>().showNextTrigger();
       	}
  else if(other.tag == "animation_trigger")
        {
          	other.GetComponent<AnimationTrigger>().StartAnimation();
        }      
    }

}
