using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoPanelAnim : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator> ();
    }

    public void playSlide() {
        anim.Play("infoAnim");
    }

    public void closeSlide() {
        anim.Play("infoAnimReverse");
    }
}
