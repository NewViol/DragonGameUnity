using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonScript : MonoBehaviour
{
    public GameObject obj;
    public TMP_Text score;
    public TMP_Text record;
    public float x = 1;
    public float y = 15;
    public float z = 16;
    public int i = 1;
    public System.Random rnd = new System.Random();
    // Start is called before the first frame update 
    void Start()
    {

        if (Time.time > i)
        {
            var dop = (rnd.NextDouble() * (3 - (-3)) + (-3));
            Instantiate(obj, new Vector3((float)dop, y, z), Quaternion.Euler(0, 0, 0));
            Debug.Log("Count");
            i += 1;
        }
    }

    private void Update()
    {
        GetMove();
        this.score.SetText(i.ToString());
    }

    private void GetMove()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * 6f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * 6f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("PauseScene");
        }
    }

    // Update is called once per frame 
    void FixedUpdate()
    {
        if (200 < i)
        {

        }
        if (Time.time > i)
        {
            var dop = (rnd.NextDouble() * (9 - (-9)) + (-9));
            Instantiate(obj, new Vector3((float)dop, y, z), Quaternion.Euler(0, 0, 0));
            Debug.Log("Count");
            i += 1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Finish"))
        {
            if (int.Parse(this.score.text) > int.Parse(this.record.text))
            {
                this.record.SetText(this.score.text);
                Debug.Log(record.text);
            }
            //Application.Quit();
            //UnityEditor.EditorApplication.isPlaying = false;
            SceneManager.LoadScene("EndGameScene");
        }
    }
}
