using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    //player spawn
    float spawnZ = 0;
    float spawnY = 0;
    float spawnX = 0;

    //input y saltos
    public float movementSpeed, rotationSpeed, jumpForce;
    Rigidbody rb;
    bool hasJump;

    //vidas
    public Text txtLifescounter;
    int lifecounter;

    //tiempo
    float timetochange;
    public Text txtCountdown;
    public Text txtGameOver;
    float timeToChange;
    int counter;
    public GameObject camara;
    float elapsedTime;

    public GameObject fondo;
    public GameObject reiniciar;
    public GameObject victoria;

    //parent
    public Transform newParent;
    public Transform newParent1;
    public Transform newParent2;
    public Transform newParent3;

    //musica

    public AudioManager miAM;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hasJump = true;
        lifecounter = 3;
        txtLifescounter.text = lifecounter.ToString();
        counter = 100;
        txtCountdown.text = counter.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, movementSpeed);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -movementSpeed);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && hasJump)
        {
            
            hasJump = false;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            miAM.PlaySalto();
        }
        //caida
        if (gameObject.transform.position.y < -2)
        {
            transform.position = new Vector3(spawnX, spawnY, spawnZ);
            miAM.PlayCaida();
            lifecounter--;
        }

        //perder por tiempo
        if (timetochange < Time.timeSinceLevelLoad)
        {
            counter--;
            if(counter > 0)
            {
                txtCountdown.text = "Tiempo restante: " + counter.ToString();
                timetochange++;
            }
            else
            {
                miAM.PlayDerrota();
                GameOver();
            }

        }
        //perder por vidas
        if (lifecounter > 0)
        {
            txtLifescounter.text = "Vidas: " + lifecounter.ToString();

        }
        else
        {
            
            miAM.PlayDerrota();
            GameOver();
        }

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Spawn")
        {
            spawnX = -0.12f;
            spawnY = 1.51f;
            spawnZ = 124.6f;
            hasJump = true;


        }

        if (col.gameObject.tag == "Ground")
        {
            hasJump = true;
        }

        if (col.gameObject.tag == "Final")
        {
            txtLifescounter.text = "";
            txtGameOver.text = "¡VICTORIA!";
            txtCountdown.text = "";
            reiniciar.SetActive(true);
            camara.SetActive(true);
            gameObject.SetActive(false);
            victoria.SetActive(true);
            miAM.PlayVictoria();
            fondo.SetActive(true);
        }

        if (col.gameObject.tag == "GroundUp")
        {
            hasJump = true;
            jumpForce = 8;

        }
        else
        {
            jumpForce = 5;
        }

        if (col.gameObject.tag == "DeathZone")
        {
            transform.position = new Vector3(spawnX, spawnY, spawnZ);
            lifecounter--;
            miAM.PlayDanio();
        }

        //Pisos Movedizos
        if (col.gameObject.tag == "PisoMovedizo")
        {
            hasJump = true;
            gameObject.transform.SetParent(newParent);

        }
        else if (col.gameObject.tag == "PisoMovedizo1")
        {
            hasJump = true;
            gameObject.transform.SetParent(newParent1);

        }
        else if (col.gameObject.tag == "PisoMovedizo2")
        {
            hasJump = true;
            gameObject.transform.SetParent(newParent2);

        }
        else if (col.gameObject.tag == "PisoMovedizo3")
        {
            hasJump = true;
            gameObject.transform.SetParent(newParent3);
        }
        else
        {
            gameObject.transform.SetParent(null);
        }

    }
    public void GameOver()
    {
        txtLifescounter.text = "";
        txtGameOver.text = "¡DERROTA!";
        reiniciar.SetActive(true);
        txtCountdown.text = "";
        camara.SetActive(true);
        gameObject.SetActive(false);
        fondo.SetActive(true);
    }
}