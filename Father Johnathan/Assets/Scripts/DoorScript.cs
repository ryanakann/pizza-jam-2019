﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : Interactable {

    public Animator doorAnimator;

    private void Start() {
        if (!doorAnimator)
            doorAnimator = GetComponent<Animator>();
    }

    public override void Interact() {
        print("OpenyClozy!");

        if (doorAnimator) {
            doorAnimator.SetTrigger("Toggle");
        }
    }
}
