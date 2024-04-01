using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(ParticleSystem))]
public class ToggleSwordParticles : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.Space;
    //private ParticleSystem fireParticle;
    public GameObject gameObject;
    bool isPlaying = true;

    private void Start()
    {
       // fireParticle = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if(!isPlaying)
            {
                gameObject.SetActive(true);
                isPlaying = true;
            } 
            else
            {
                gameObject.SetActive(false);
                isPlaying = false;
            }
        }
    }
}
