
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public Rigidbody2D rb;

    private void FixedUpdate()
    {
        if (rb.transform.position.y < -4f)
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Next")
        {
            SceneManager.LoadScene("Game2");
        }
    }
}
