using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    [SerializeField] private GameObject boton, task, message;
    private bool tracked;

    public void Tracked()
    {
        if (!tracked)
        {
            tracked = true;
            task.SetActive(false);
            boton.SetActive(true);
            message.SetActive(true);
        }
    }

    public void OnContinue()
    {
        SceneManager.LoadScene(1);
    }
}
