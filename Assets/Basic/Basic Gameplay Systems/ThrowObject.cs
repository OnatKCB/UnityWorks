using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityWorks.BasicGameplaySystems
{
    public class ThrowObject : MonoBehaviour
{
    [SerializeField] Transform player, playerCam;
    [SerializeField] bool hasPlayer, beingCarried, touched;
    [SerializeField] float throwForce;
    [SerializeField] AudioClip[] soundToPlay;
    [SerializeField] private AudioSource _audio;
    [SerializeField] int damage;

     void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 2.5f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }
        if (hasPlayer && Input.GetButtonDown("Use"))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
        }
        if (beingCarried)
        {
            if (touched)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }
            if (Input.GetMouseButtonDown(0))
                {
                    GetComponent<Rigidbody>().isKinematic = false;
                    transform.parent = null;
                    beingCarried = false;
                    GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
                RandomAudio();
                }
                else if (Input.GetMouseButtonDown(1))
                {
                GetComponent<Rigidbody>().isKinematic = false;
                    transform.parent = null;
                beingCarried = false;
                }
            }
        }
    void RandomAudio()
    {
        if (_audio.isPlaying){
            return;
                }
        _audio.clip = soundToPlay[Random.Range(0, soundToPlay.Length)];
        _audio.Play();

    }
   void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }
}
}
