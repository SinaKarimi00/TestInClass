using System;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotateSpeed;

    [SerializeField] private TextMeshProUGUI coinText;

    [SerializeField] private TextMeshProUGUI gameMessage;

    // [SerializeField] private Transform playerTransform;
    [SerializeField] private Button resetButton;

    private int _speedSign;
    private int _rotateSpeedSign;
    private int coin;

    private int age;

    private void Start()
    {
        resetButton.onClick.AddListener(ResetGame);
        resetButton.onClick.AddListener(ResetGame);
        resetButton.onClick.AddListener(ResetGame);
        resetButton.onClick.RemoveAllListeners();
    }

    public void ResetGame()
    {
        Debug.Log("Reset Game");
    }

    private void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            _speedSign = 1;
        }

        else if (Keyboard.current.sKey.isPressed)
        {
            _speedSign = -1;
        }
        else
        {
            _speedSign = 0;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            _rotateSpeedSign = 1;
        }

        else if (Keyboard.current.dKey.isPressed)
        {
            _rotateSpeedSign = -1;
        }

        else
        {
            _rotateSpeedSign = 0;
        }


        transform.Translate(0f, _speedSign * speed * Time.deltaTime, 0f);
        transform.Rotate(0f, 0f, _rotateSpeedSign * rotateSpeed * Time.deltaTime);
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            Debug.Log("Get Coin");
            Destroy(other.gameObject, 1f);
            coin += 10;
            coinText.text = coin.ToString();
        }

        else if (other.tag == "Enemy")
        {
            Destroy(gameObject);
            Debug.Log("GameOver");
            gameMessage.gameObject.SetActive(true);
            gameMessage.text = "GameOver";
        }
    }
}