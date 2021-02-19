using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {
        GetComponent<AudioSource>().Play();
        StartCoroutine(LoadSound());
    }

    IEnumerator LoadSound() {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Game Over");
    }
}
