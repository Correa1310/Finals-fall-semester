using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    private float _horizontalInput;

    private float _forwardInput;

    public AudioClip coinSound;

    public AudioClip zombieSound;

    private Rigidbody _playerRb;

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        _playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");

        Vector3 lookDirection = new Vector3(_horizontalInput, 0f, _forwardInput);

        _playerRb.AddForce(lookDirection * speed);
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            _playerAudio.PlayOneShot(coinSound, 1f);
            GameObject.Find("Spawn Manager").GetComponent<SpawnManager>().
            SpawnCollectibleObject();
        }
    }

    void OnCollisonEnter(Collision other)
    {
        if(other.gameObjects.CompareTag("Zombie"))
        {
          _playerAudio.PlayOneShot(zombieSound, 1f);
          GameObject.Find("Canvas").GetComponent<UIManager>().GameOver();
        }
    }
}
