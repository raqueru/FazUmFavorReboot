using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;
    public TRIGGERCREDITS end;
    public DialogueManager Dialogue;
    public AudioSource Audio;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other) {
        
        if (other.CompareTag("Player")){

            Debug.Log("AA");
         StartCoroutine(StartFade(Audio,2,0));
         StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1));

          
        
        }
    
}
    IEnumerator LoadLevel(int levelIndex){
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(levelIndex);


    }

    public void LoadLevelStartScene(){
       
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }

     public static IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audioSource.volume;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }
}

 