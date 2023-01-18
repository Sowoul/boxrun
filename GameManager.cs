using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool end=false;
    public NewBehaviourScript nb;
    public void EndGame() {
        if (end == false){
            end=true;
            Debug.Log("oops");
            Invoke("restart",1);
        }
    }
    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
