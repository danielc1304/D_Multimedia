using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TreaScript : MonoBehaviour
{
    private Animator anim;
    public GameObject door;
    private Animator doorAnim;
    public GameObject trash;

    [Header("Dialogs")]
    [SerializeField] private GameObject dialogCanvas;
    [SerializeField] private AudioSource dialogAudioSource;
    [SerializeField] private CanvasGroup dialogCanvasGroup;
    [SerializeField] private TextMeshProUGUI dialogTMP;

    void Start()
    {
        anim = GetComponent<Animator>();
        doorAnim = door.GetComponent<Animator>();
        Invoke("playDoorAnim", 4f);
        Invoke("playStartAnimation", 5f);
    }

    private void PlayDoorAnim()
    {
        doorAnim.Play("open");
    }

    private void PlayStartAnimation()
    {
        anim.Play("intro");
    }

    private void Drop()
    {
        Instantiate(trash, (transform.position + new Vector3(0f, -0.4f, 0f)), Quaternion.identity);
    }

    public void ReproduceTreaDialog(DialogSO dialogSO)
    {
        dialogTMP.text = dialogSO.dialogText;
        dialogAudioSource.clip = dialogSO.dialogAudio;
        dialogAudioSource.Play();
    }
}
