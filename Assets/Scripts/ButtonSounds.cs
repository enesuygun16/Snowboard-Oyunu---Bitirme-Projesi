using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSound : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip hoverSound;

    public void OnPointerEnter(PointerEventData eventData)
    {
        audioSource.PlayOneShot(hoverSound);
    }
}
