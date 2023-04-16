using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    private readonly int deathHeight = -100;
    private readonly Vector3 respawnPosition = new(0f, 0f, 0f);
    [SerializeField] private GameObject menuButton;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private Image menuButtonImage;
    [SerializeField] private TMP_Text gameOverText;

    void Update()
    {
        if (transform.position.y >= deathHeight)
        {
            return;
        }

        if (PlayerProperties.playerLifes > 3)
        {
            PlayerProperties.playerLifes--;
            transform.position = respawnPosition;
        }
        else
        {
            Time.timeScale = 0;
            deathScreen.SetActive(true);
            SetToPlayerColors();
            GameProperties.isPaused = true;
            EventSystem.current.SetSelectedGameObject(menuButton);
        }
    }
    private void SetToPlayerColors()
    {
        Color color = PlayerProperties.playerColor;
        menuButtonImage.color = color;
        gameOverText.color = color;
    }
}
