using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Information : MonoBehaviour
{
    private static GameObject Instance;
    private string gameID;

    void Awake(){
        if(Instance == null){
            Instance = transform.gameObject;
            DontDestroyOnLoad(Instance);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenGame(string id){
        SetGameID(id);
        SceneManager.LoadScene("GeoGame1");
    }

    void LoadGeoGame(){
        SceneManager.LoadScene("GeoGame1");
    }

    public void LoadMainMenu(){
        SceneManager.LoadScene("GameMenu");
    }

    public string GetGameID(){
        return gameID;
    }

    public void SetGameID(string id){
        gameID = id;
    }
}
