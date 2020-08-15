using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;   
 
public class MusicClass : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
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