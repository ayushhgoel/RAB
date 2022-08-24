using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraControler : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Player;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - Player.transform.position;
    }
    private void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
    
    public void reload()
    {
        SceneManager.LoadScene(1);
    }
}
