using UnityEngine;
using UnityEngine.SceneManagement;
 
public class MusicClass : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            if (_audioSource.isPlaying) return;
            _audioSource.Play();
        }
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }

    public void ResumeMusic()
    {
        _audioSource.UnPause();
    }

    public void PauseMusic()
    {
        _audioSource.Pause();
    }
}