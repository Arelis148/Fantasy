using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void NovaHra()
    {
        SceneManager.LoadScene("LocationSelect");
    }

    public void Konec()
    {
        Application.Quit();
    }

    public void Pokracovat()
    {
        Debug.Log("Pokračování zatím není dostupné.");
    }
}
