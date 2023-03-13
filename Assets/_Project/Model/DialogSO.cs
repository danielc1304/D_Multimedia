using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialog_", menuName = "DM/TREADialog")]
public class DialogSO : ScriptableObject
{
    [TextArea] public string dialogText;
    public AudioClip dialogAudio;
}
