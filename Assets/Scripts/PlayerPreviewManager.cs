using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerPreviewManager : MonoBehaviour
{
    public TMP_Text previewText;
    public string[] playerPreviewText;
    public RawImage previewPlayer;
    public RenderTexture[] playerPreviews;

    void Start() 
    {
        int index = PlayerPrefs.GetInt("selectedPlayer", 0);
        previewText.text = playerPreviewText[index];
        previewPlayer.texture = playerPreviews[index];
    }

    public void SelectPlayer(int index)
    {
        previewPlayer.texture = playerPreviews[index];

        if (previewText != null)
        {
            previewText.text = playerPreviewText[index];
        }

        PlayerPrefs.SetInt("selectedPlayer", index);
    }
}
