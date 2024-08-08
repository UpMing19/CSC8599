using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenuList : MonoBehaviour
{
    public GameObject menuList;
    [SerializeField] private bool menuKeys = true;
    [SerializeField] private AudioSource bgmSound;

    private InputAction pauseMenuAction;

    private void Awake()
    {
        pauseMenuAction = new InputAction("PauseMenu", binding: "<Keyboard>/p");
        pauseMenuAction.Enable();
    }

    private void OnEnable()
    {
        pauseMenuAction.started += OnPauseMenuStarted;
    }

    private void OnDisable()
    {
        pauseMenuAction.started -= OnPauseMenuStarted;
    }

    private void OnPauseMenuStarted(InputAction.CallbackContext context)
    {
        ToggleMenu();
    }

    private void ToggleMenu()
    {
        bool menuActive = menuList.activeSelf;
        if (menuActive)
        {
            LockMouse();
        }
        else
        {
            UnlockMouse();
        }
        menuList.SetActive(!menuActive);
        menuKeys = !menuActive;
        Time.timeScale = menuActive ? 1f : 0f;

    }

    private void OnDestroy()
    {
        pauseMenuAction.Disable();
        pauseMenuAction.Dispose();
    }
    public void Return()
    {
        bool menuActive = menuList.activeSelf;
        if (menuActive)
        {
            LockMouse();
        }
        else
        {
            UnlockMouse();
        }
        menuList.SetActive(!menuActive);
        menuKeys = !menuActive;
        Time.timeScale = menuActive ? 1f : 0f;
    }
    public void Remake()
    {
        SceneManager.LoadScene("StartUI");
        Time.timeScale = 1;
    }
    public void Exit()
    {
        Application.Quit();
    }
    private void LockMouse()
    {
        // 隐藏鼠标光标
        Cursor.visible = false;
        // 锁定鼠标位置
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void UnlockMouse()
    {
        // 显示鼠标光标
        Cursor.visible = true;
        // 解锁鼠标位置
        Cursor.lockState = CursorLockMode.None;
    }
}