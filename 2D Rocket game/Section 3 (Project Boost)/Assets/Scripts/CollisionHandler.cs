using UnityEngine;
using  UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{

    [SerializeField] float delayParameter=3f;
    [SerializeField] AudioClip defeatExplosion;
    [SerializeField] AudioClip success;
    AudioSource audioSource;

    bool isTransitioning=false; 
    void Start()
    {
        audioSource=GetComponent<AudioSource>();
    
    }
    void OnCollisionEnter(Collision other) 
    {
        if (isTransitioning){return;}

        switch (other.gameObject.tag)
        {
            case "StartPad":
                Debug.Log("Starting pad");
                break;

            case "Finish":
                StartSuccessSequence();
                break;

            default:
            //Invoke delays the given method by some time Invoke("method",delaysInSeconds)
                StartCrashSequence();
                break;

        }

    }    


    void ReloadLevel()
    {
        int currentSceneIndex=SceneManager.GetActiveScene().buildIndex;   
        SceneManager.LoadScene(currentSceneIndex);
        //0 is the numberer of the scene in file/Build Settings
    }

    void NextLevel()
    {
        int currentSceneIndex=SceneManager.GetActiveScene().buildIndex; 
        int nextSceneIndex=currentSceneIndex+1; 
        if (nextSceneIndex==SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex=0;
        } 
        SceneManager.LoadScene(nextSceneIndex);

    }


    void StartCrashSequence()
    {
        
        isTransitioning =true;
        audioSource.Stop();
        GetComponent<Movement1>().enabled=false;
        Invoke("ReloadLevel",delayParameter);
        audioSource.PlayOneShot(defeatExplosion);

    }


    void StartSuccessSequence()
    {
        audioSource.Stop();
        GetComponent<Movement1>().enabled=false;
        Invoke("NextLevel",delayParameter);
        audioSource.PlayOneShot(success);



    }
}


