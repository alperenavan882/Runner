using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public float Health;

    Vector3 temp;

    public float scalePoint;

    [SerializeField] private LayerMask playerMaskHealth;


    private void Awake()
    {
        Health = 1f;
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.layer == 6)  
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);           
        }

        if (other.gameObject.layer == 10)
        {
            SceneManager.LoadScene(0);
        }

        if (other.gameObject.layer == 9)
        {
            Destroy(other.gameObject);

            scaleUp();

            Health++;
        }

        if (other.gameObject.layer == 8)
        {
            Destroy(other.gameObject);

            scaleDown();

            Health--;

            lifeCheck();
        }

        if(other.gameObject.name == "MathPlusOne")
        {
            scaleUp();
            Health += 1;
        }

        if (other.gameObject.name == "FakeMathXFour" )
        {
            scaleUp();
            Health *= 4;
        }

        if (other.gameObject.name == "FakeMathFour")
        {
            scaleUp();
            Health *= 4;
        }
        
        if (other.gameObject.name == "FakeMathXTwo")
        {
            scaleUp();
            Health *= 2;
        }


        if (other.gameObject.name == "FakeMathDividedByThree")
        {
            scaleDown();
            Health /= 3;
        }

        if (other.gameObject.name == "FakeMathSubFifty")
        {
            scaleDown();
            Health -= 50;
            lifeCheck();
        }

        if (other.gameObject.name == "MathPlusTen")
        {
            scaleUp();
            Health += 10;
        }

        if (other.gameObject.name == "FakeMathPlusTen" || other.gameObject.name == "FakeMathPlusTen (1)")
        {
            scaleUp();
            Health += 10;
        }

        if (other.gameObject.name == "MathSubOne")
        {
            scaleDown();
            Health -= 1;
            lifeCheck();
        }

        if (other.gameObject.name == "FakeMathSubTen" || other.gameObject.name == "FakeMathSubTen (1)")
        {
            scaleDown();
            Health -= 10;
            lifeCheck();
        }

        if (other.gameObject.name == "BigTrap" || other.gameObject.name == "MiddleTrap" || other.gameObject.name == "SmallTrap")
        {
            Health = 0;
            lifeCheck();
        }


    }

    private void lifeCheck()
    {
        if (Health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void scaleUp()
    {
        temp = transform.localScale;

        temp.x += scalePoint;
        temp.y += scalePoint;

        transform.localScale = temp;
    }

    private void scaleDown()
    {
        temp = transform.localScale;

        temp.x -= scalePoint;
        temp.y -= scalePoint;

        transform.localScale = temp;
    }


}
