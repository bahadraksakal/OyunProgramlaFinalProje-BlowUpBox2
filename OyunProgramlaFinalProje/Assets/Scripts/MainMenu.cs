using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public int loadEdilecekIndex;
    public Button ResumeButton;
    void Start()
    {
        bool kayitCheck=PlayerPrefs.HasKey("savedScene");
        if(kayitCheck){
            loadEdilecekIndex=PlayerPrefs.GetInt("savedScene");
            ResumeButton.interactable=true;
            //Buton etkileşimli
        }else{
            ResumeButton.interactable=false;
            //button etkileşimsiz
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void newGame(){
        Debug.Log("new game e tıklnadı");
        StartCoroutine(goNewGame());
    }
    public IEnumerator goNewGame()
    {
        yield return new WaitForSeconds(1.0f); // beklemeyince bazen hata alıyor
        PlayerPrefs.DeleteAll();
        int suankiSahneIndex=SceneManager.GetActiveScene().buildIndex;
        int sonrakiSahneIndex=suankiSahneIndex+1;
        Debug.Log("sunakiSahneIndex:"+suankiSahneIndex+"\nSonrakiSahneIndex:"+sonrakiSahneIndex); 
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sonrakiSahneIndex);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
           
    } 
    public void resume(){
        Debug.Log("Resume tıklandı");
        StartCoroutine(goResume());
    }
    public IEnumerator goResume()
    {
        yield return new WaitForSeconds(1.0f); // beklemeyince bazen hata alıyor
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(loadEdilecekIndex);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
           
    } 
}
