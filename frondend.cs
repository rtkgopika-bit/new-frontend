using UnityEngine;
using UnityEngine.UI;

public class UIFlowManager : MonoBehaviour
{
    [Header("Screens")]
    public GameObject splashScreen;
    public GameObject loginScreen;
    public GameObject signupScreen;
    public GameObject homeScreen;

    [Header("Input Fields")]
    public InputField usernameInput;
    public InputField emailInput;
    public InputField passwordInput;

    [Header("Profile Fields")]
    public InputField profileNameInput;
    public Dropdown roleDropdown;

    [Header("Home UI")]
    public InputField searchBar;
    public Button arScannerButton;

    void Start()
    {
        ShowSplash();
    }

    // ===================== SCREEN NAVIGATION =====================

    public void ShowSplash()
    {
        splashScreen.SetActive(true);
        loginScreen.SetActive(false);
        signupScreen.SetActive(false);
        homeScreen.SetActive(false);
    }

    public void ShowLogin()
    {
        splashScreen.SetActive(false);
        loginScreen.SetActive(true);
        signupScreen.SetActive(false);
        homeScreen.SetActive(false);
    }

    public void ShowSignup()
    {
        splashScreen.SetActive(false);
        loginScreen.SetActive(false);
        signupScreen.SetActive(true);
        homeScreen.SetActive(false);
    }

    public void ShowHome()
    {
        splashScreen.SetActive(false);
        loginScreen.SetActive(false);
        signupScreen.SetActive(false);
        homeScreen.SetActive(true);
    }

    // ===================== AUTH ACTIONS =====================

    public void LoginUser()
    {
        Debug.Log("Login User: " + emailInput.text);
        // Firebase Auth call here
        ShowHome();
    }

    public void SignupUser()
    {
        Debug.Log("Signup User: " + emailInput.text);
        // Firebase Auth + Firestore profile create
        ShowSignup();
    }

    public void SaveProfile()
    {
        Debug.Log("Profile Saved: " + profileNameInput.text);
        ShowHome();
    }

    // ===================== HOME ACTIONS =====================

    public void OpenARScanner()
    {
        Debug.Log("AR Scanner Activated");
        // AR Foundation Session Enable
        // Load AR Scene or Enable AR Camera
    }

    public void SearchMonument()
    {
        Debug.Log("Searching: " + searchBar.text);
        // Query Firestore monuments
    }
}