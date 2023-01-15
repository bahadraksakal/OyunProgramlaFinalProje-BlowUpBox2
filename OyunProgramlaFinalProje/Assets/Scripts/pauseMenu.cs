using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    private static bool gamePause=false;
    public GameObject pauseMenuUI;
    private float escape;
    private bool escapeFlag=false;
    private bool escapeFlag2=false;


    void Update()
    {
        escape = Input.GetAxisRaw("Cancel");
        if(escape!=0){
            escapeFlag=true;
        }        
        if(escapeFlag){
            if(escape==0){
                escapeFlag2=true;
            }            
        }
        if(escapeFlag && escapeFlag2){
            if(gamePause){
                pauseMenuUI.SetActive(false);
                Time.timeScale=1f;
                gamePause=false;
            }else{
                pauseMenuUI.SetActive(true);
                Time.timeScale=0.00001f;
                gamePause=true;
            }
            escapeFlag=false;
            escapeFlag2=false;
        }
         //oyun sadece resume ile devam eder. escape basılı tutarsan hata almazsın. Sorunsuz açılıp kapanan menü +20 puan.
    }
    public void restart(){
        int suankiSahne=SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(suankiSahne,LoadSceneMode.Single);
        pauseMenuUI.SetActive(false);
        Time.timeScale=1f;
        gamePause =false;
    }
    public void resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale=1f;
        gamePause=false;
    }
    public void MainMenu(){       
        StartCoroutine(GoMainMenu());
        Time.timeScale=1f;
        gamePause=false;
    }
    public IEnumerator GoMainMenu()
    {
        yield return new WaitForSeconds(1.0f); // beklemeyince bazen hata alıyor        
        int suankiSahne=SceneManager.GetActiveScene().buildIndex;
        bool kayitCheck=PlayerPrefs.HasKey("savedScene");
        if(kayitCheck){
            Debug.Log("Kayıt Bulundu Kontrol Yapılıyor");
            int eskiKayitIndex=PlayerPrefs.GetInt("savedScene");
            if(eskiKayitIndex!=suankiSahne){
                PlayerPrefs.SetInt("savedScene",suankiSahne);
                Debug.Log("Kayıtlar farklı üstüne yazılıyor");
            }else{
                Debug.Log("Kayıtlar Aynı Boşuna İşlem Yapma");
            }
        }else{
            Debug.Log("Kayıt Bulunamadı Yeni Kayıt Oluşturuluyor.");
            PlayerPrefs.SetInt("savedScene",suankiSahne);
        }
        
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(0);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
         
    } 
}
