using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallControl1 : MonoBehaviour
{
    public pauseMenu pauseMenu;
    private Vector3 mouseVec;
    private bool start=true;
    public GameObject crosshair;
    public GameObject kare;
    public GameObject top;
    public GameObject youWinMenuUI;
    public GameObject youLoseMenuUI;
    public Rigidbody2D rb;
    public int skor = 0;
    int can = 6;
    public Text skorTxt;
    public Text canTxt;

    public float ballSpeed;
    private float mouse0;
    private bool mouse0Flag=false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(start){
            mouseVec = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,Camera.main.transform.position.z));
            crosshair.transform.position = new Vector2(mouseVec.x,mouseVec.y);

            Vector3 fark = mouseVec - top.transform.position;

                mouse0=Input.GetAxis("Fire1");
                if(mouse0!=0){
                    mouse0Flag=true;
                }
                if(can>0 && mouse0Flag){
                    start=false;
                    float uzaklik = fark.magnitude; //fark vektorunun buyuklugu
                    Vector2 yon = fark / uzaklik; //yon vektorunun olusturulmasi
                    yon.Normalize(); //vektor buyuklugu 1'e indirilir. (sadece yon almasi icin)
                    ballMove(yon);
                }
                /*
                else if(can==0){
                    SceneManager.LoadScene("Oyun",LoadSceneMode.Single);
                }
                */
                 //you lose menu eklendigi icin etkisiz
                mouse0=0;
                mouse0Flag=false;          
        }
        
    }
    void ballMove(Vector2 yon){
            rb.velocity = yon * ballSpeed;
    }
    
    void OnCollisionEnter2D(Collision2D col){
        if(col.collider.name == "yatay_alt"){
            //Destroy(top,0);
            Vector3 pos = new Vector3(0,-3.5f,0);
            Vector3 pos2 = new Vector3(0.01f,-4,0);
            top.transform.position=pos;
            kare.transform.position=pos2;
            GetComponent<Rigidbody2D>().velocity=new Vector2(0,0);
            can--;
            canTxt.text = "Can: " + can.ToString();
            start = true;
            if (can <= 0)
            {
                youLoseMenuUI.SetActive(true);
                Time.timeScale = 0.00001f;
            }
        }
        if(col.collider.tag == "block" || col.collider.tag == "blackBlock"){
            skor++;
            skorTxt.text = "Skor: " + skor.ToString();
            if(skor==23){
                StartCoroutine(GoNextLevel());
                //youWinMenuUI.SetActive(true);
                //Time.timeScale=0.00001f;
            }
        } 
    }

    public void MainMenu(){
        StartCoroutine(goMainMenu());
        youWinMenuUI.SetActive(false);
        youLoseMenuUI.SetActive(false);
        Time.timeScale=1f;
    }

    public IEnumerator GoNextLevel()
    {
        //bu sayfadki oyun ismini 1 indexi ile değiş
        //menupausedeki oyun ismini index 1 ile değiş
        yield return new WaitForSeconds(1.0f); // beklemeyince bazen hata alıyor

        int suankiSahneIndex=SceneManager.GetActiveScene().buildIndex;
        int sonrakiSahneIndex=suankiSahneIndex+1;
        Debug.Log("sunakiSahneIndex:"+suankiSahneIndex+"\nSonrakiSahneIndex:"+sonrakiSahneIndex);  

        int sonSahneIndex=SceneManager.sceneCountInBuildSettings-1;
        Debug.Log("sonSahneIndex:"+sonSahneIndex);
        if(sonrakiSahneIndex>sonSahneIndex){
            youWinMenuUI.SetActive(true);
            Time.timeScale=0.00001f;
            yield return null;
        }else{
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sonrakiSahneIndex);
            while (!asyncLoad.isDone)
            {
                yield return null;
            }
        }       
    }
    public IEnumerator goMainMenu()
    {
        yield return new WaitForSeconds(1.0f); // beklemeyince bazen hata alıyor        
        PlayerPrefs.DeleteAll();// eğer ölürsen tüm kayıtların yok olur.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(0);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
           
    } 
}
