﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {
        GameObject defender = collision.gameObject;
        if (collision.GetComponent<Defender>()) {
            GetComponent<Attacker>().Attack(defender);
        }
    }
}
