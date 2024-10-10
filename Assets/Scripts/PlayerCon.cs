using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject m_player = null;
    [SerializeField] Rigidbody2D m_playerRigid = null;
    [SerializeField] float x = 0.0f;
    [SerializeField] float m_speed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        m_playerRigid.velocity += new Vector2(x * m_speed *Time.deltaTime, 0);
    }
}
