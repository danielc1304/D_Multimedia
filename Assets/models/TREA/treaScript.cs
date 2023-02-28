using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treaScript : MonoBehaviour
{
    private Animator anim;
    public GameObject door;
    private Animator doorAnim;
    public GameObject trash;

    void Start()
    {
        anim = GetComponent<Animator>();
        doorAnim = door.GetComponent<Animator>();
        Invoke("playDoorAnim", 4f);
        Invoke("playStartAnimation", 5f);
    }

    private void playDoorAnim()
    {
        doorAnim.Play("open");
    }

    private void playStartAnimation()
    {
        anim.Play("intro");
    }

    private void drop()
    {
        Instantiate(trash, (transform.position + new Vector3(0f, -0.4f, 0f)), Quaternion.identity);
    }
}
