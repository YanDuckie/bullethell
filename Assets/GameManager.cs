using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Unity.Properties;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


 
    // Start is called before the first frame update
    public GameObject Bullet ;
    public Transform Pos ;
    public void NextLevel()
    {
           
            
      UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
