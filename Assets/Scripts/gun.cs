using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class gun : MonoBehaviour
{
    public Camera cam;
    public bool canShoot = true;
    public Animator gunAnim;
    public AudioSource gunShotSound;
    void Start()
    {
        gunShotSound = GetComponent<AudioSource>();
        ResetShot();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && canShoot)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        gunAnim.SetTrigger("Shoot");

        canShoot = false;
        gunShotSound.Play();

        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
        {
            if (hit.transform.tag == "gatsbyHitbox")
            {
                SceneManager.LoadScene(6);
            }
            Debug.Log(hit.transform.name);
        }
    }

    public void ResetShot()
    {
        canShoot = true;
        gunAnim.ResetTrigger("Shoot");
    }
}
