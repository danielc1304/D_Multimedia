using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;
using System;

namespace DM
{
    public class TreaManager : Singleton<TreaManager>
    {
        private Animator anim;
        public GameObject door;
        private Animator doorAnim;
        public GameObject trash;

        [Header("Dialogs")]
        [SerializeField] private GameObject dialogCanvas;
        private CanvasGroup dialogCanvasGroup;

        [SerializeField] private AudioSource dialogAudioSource;

        [SerializeField] private TextMeshProUGUI dialogTMP;

        void Start()
        {
            InitializeVariables();
            //Invoke("playDoorAnim", 4f);
            //Invoke("playStartAnimation", 5f);
        }

        private void InitializeVariables()
        {
            anim = GetComponent<Animator>();
            doorAnim = door.GetComponent<Animator>();
            dialogCanvasGroup = dialogCanvas.GetComponent<CanvasGroup>();
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
            FadeInDialogCanvas(()=> 
            {
                dialogTMP.text = dialogSO.dialogText;
                dialogAudioSource.clip = dialogSO.dialogAudio;
                dialogAudioSource.Play();
                StartCoroutine(WaitForSound(dialogSO.dialogAudio.length, ()=>FadeOutDialogCanvas()));
            });
        }

        private void FadeOutDialogCanvas(Action onFadeCompleated = null)
        {
            dialogCanvasGroup.DOFade(0f, 0.5f).OnComplete(() =>
            {
                onFadeCompleated();
            });
        }

        private void FadeInDialogCanvas(Action onFadeCompleated = null)
        {
            dialogCanvasGroup.DOFade(1f, 1f).OnComplete(() =>
            {
                onFadeCompleated();
            });
        }

        IEnumerator WaitForSound(float duration, Action onFinishedSound)
        {
            yield return new WaitForSeconds(duration);
            print("FinishAudio");
            onFinishedSound();
        }
    }
}