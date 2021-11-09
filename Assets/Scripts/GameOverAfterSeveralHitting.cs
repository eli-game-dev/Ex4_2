using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class GameOverAfterSeveralHitting : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [Tooltip("amount of hitting to game over")][SerializeField] int AmountOfHitting;
    private int hits;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled) {
            hits++;
            Destroy(other.gameObject);
            if (hits>=AmountOfHitting)
            {
                Destroy(this.gameObject);
                UnityEngine.SceneManagement.SceneManager.LoadScene(1);
                // Application.Quit();
                // #if UNITY_EDITOR
                // UnityEditor.EditorApplication.isPlaying = false;
                // #endif
            }
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
