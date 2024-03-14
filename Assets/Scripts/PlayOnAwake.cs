using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayOnAwake : MonoBehaviour
{
    public AudioSource Open1Sht;
    public Animator anim;
    public string animName;
    void Awake()
    {
        anim.Play(animName);
        Open1Sht.Play();
    }
}
