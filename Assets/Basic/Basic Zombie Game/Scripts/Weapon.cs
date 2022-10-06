using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityWorks.BasicZombieGame
{
    public class Weapon : MonoBehaviour
{
    AudioSource ShootSound;
    Animator WeaponAnim;
    Camera cam;
    public GameObject fireEffect, bloodEffect;
    public TMPro.TextMeshProUGUI bulletText;
    float fireRate, fireTime;
    int bulletAmountsInMagazine, totalBullet;
    // Start is called before the first frame update
    void Start()
    {
        ShootSound = GetComponent<AudioSource>();
        WeaponAnim = GetComponent<Animator>();
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        showLeftBullets();
    }

    // Update is called once per frame
    void Update()
    {
        WeaponAnimation();
        if(Input.GetKeyDown(KeyCode.R))
        {
            if(totalBullet > 0)
            {
                reloadMagazine();
            }
        }
        if(Input.GetMouseButton(0))
        {
            if(Time.time >= fireTime)
            {
                if(bulletAmountsInMagazine > 0)
                {
                    fire();
                    fireTime = Time.time + fireRate;
                }
                else
                {
                    stopFire();
                }
            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            stopFire();
        }
    }
    void showLeftBullets()
    {
        bulletText.text = bulletAmountsInMagazine + "/" + totalBullet;
    }
    void WeaponAnimation()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            WeaponAnim.SetBool("Walk", true);
        }
        else
        {
            WeaponAnim.SetBool("Walk", false);
        }
    }
    void reloadMagazine()
    {
        WeaponAnim.SetTrigger("Magazine");
        bulletAmountsInMagazine = 30;
        totalBullet -= 30;
        showLeftBullets(); 
    }
    void fire()
    {
        bulletAmountsInMagazine --;
        showLeftBullets();
        if(ShootSound.isPlaying == false)
        {
            ShootSound.Play();
            fireEffect.SetActive(true);
            WeaponAnim.SetBool("Fire", true);
        }
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider.gameObject.tag == "Enemy")
            {
                hit.collider.gameObject.GetComponent<Zombie>().DecreaseHealth(20);
                GameObject newBloodEffect = Instantiate(bloodEffect, hit.point, Quaternion.identity);
                Destroy(newBloodEffect, 0.5f);
            }
        }
    }
    void stopFire()
    {
        WeaponAnim.SetBool("Fire", false);
        ShootSound.Stop();
        fireEffect.SetActive(false);
    }
}
}
