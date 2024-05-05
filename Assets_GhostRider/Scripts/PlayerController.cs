using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    private Vector2 targetPos;
    public float yIncrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 3;

    public GameObject effect;
    void Update()
    {
        if(health <= 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight) {
            launchParticle();
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
        } 
        else if(Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight){
            launchParticle();
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
        }
    }

    public void updateHealth(int damage){
        health -= damage;
    }

    private void launchParticle(){
        Instantiate(effect, transform.position, Quaternion.identity);
    }
}
