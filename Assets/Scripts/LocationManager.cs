using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationManager : MonoBehaviour
{
    public void ZvolLokaci(string lokace)
    {
        PlayerPrefs.SetString("StartovniLokace", lokace);
        Debug.Log("Zvolená lokace: " + lokace);
        SceneManager.LoadScene("FirstInteraction");
    }
}
