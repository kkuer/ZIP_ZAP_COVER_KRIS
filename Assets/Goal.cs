using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public CircleCollider2D circleCollider;
    public bool inRange = false;
    public string nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player" || collision.gameObject.tag == "ball") 
        {
            inRange = true;
            StartCoroutine(waitWin());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inRange = false;
    }

    private IEnumerator waitWin()
    {
        yield return new WaitForSeconds(3f);
        if (inRange)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }

}
