using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class DeathPlayer : MonoBehaviour
{
    [SerializeField] private GameObject DeathMenu;
    [SerializeField] private GameObject player;

    public void DeathPlayerEvent()
    {
        AnimationPlayerController.singletonAnim.AnimatorPlayer("Death", true);
        StartCoroutine(DeathWhait());

        DeathMenu.SetActive(true);
        player.layer = LayerMask.NameToLayer("Default");
    }

    IEnumerator DeathWhait()
    {
        yield return new WaitForSecondsRealtime(1f);
    }
}
