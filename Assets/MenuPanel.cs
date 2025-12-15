using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private Button m_PlayButton;

    private void OnEnable()
    {
        m_PlayButton.onClick.RemoveAllListeners();
        m_PlayButton.onClick.AddListener(OnClickPlayButton);
    }

    void OnClickPlayButton()
    {
        InGameUi.Instance.m_FindOrCreateRoom.gameObject.SetActive(true);
    }
}
