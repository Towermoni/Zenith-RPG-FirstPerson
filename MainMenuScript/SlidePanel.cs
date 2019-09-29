using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidePanel : MonoBehaviour
{

    public GameObject Panel;
    Animator animator;
    bool opened;

    private void Start()
    {
        opened = false;
        if (opened)
        {
            animator.SetTrigger("WarriorSlideMenu");
        }
    }

    private void openSlide()
    {
        opened = true;
    }

    private void closeSlide()
    {
        opened = false;
    }
    
}
