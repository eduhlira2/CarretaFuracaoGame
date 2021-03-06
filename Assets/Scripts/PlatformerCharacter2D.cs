using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Just in case so no "duplicate definition" stuff shows up
//namespace UnityStandardAssets.Copy._2D
//{
    public class PlatformerCharacter2D : MonoBehaviour
    {
        [SerializeField] private float m_MaxSpeed = 10f;                    // The fastest the player can travel in the x axis.
        [SerializeField] private float m_JumpForce = 400f;                  // Amount of force added when the player jumps.
        [SerializeField] private bool m_AirControl = false;                 // Whether or not a player can steer while jumping;
        [SerializeField] private LayerMask m_WhatIsGround;                  // A mask determining what is ground to the character

        private Transform m_GroundCheck;    // A position marking where to check if the player is grounded.
        const float k_GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
        private bool m_Grounded;            // Whether or not the player is grounded.
        private Animator m_Anim;            // Reference to the player's animator component.
        private Rigidbody2D m_Rigidbody2D;
        private bool m_FacingRight = true;  // For determining which way the player is currently facing.
		public static int pontuacao;
		public UnityEngine.UI.Text txtPontos;
		public GameObject gameOverScreen;
	public GameObject Player;
	public GameObject Restart;
	Vector2 forca;
	public GameObject VikingMorto;
	public GameObject PauseButton;


	void Start(){
		pontuacao = 0;
		PlayerPrefs.SetInt ("pontuacao", pontuacao);

	}

	void Update (){
		txtPontos.text = pontuacao.ToString ();
	}

        private void Awake()
        {
            // Setting up references.
            m_GroundCheck = transform.Find("GroundCheck");
            m_Anim = GetComponent<Animator>();
            m_Rigidbody2D = GetComponent<Rigidbody2D>();


        }


        private void FixedUpdate()
        {
            m_Grounded = false;

            // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
            // This can be done using layers instead but Sample Assets will not overwrite your project settings.
            Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i].gameObject != gameObject)
                    m_Grounded = true;
            }
            m_Anim.SetBool("Ground", m_Grounded);
        }


        public void Move(float move, bool jump)
        {
            //only control the player if grounded or airControl is turned on
            if (m_Grounded || m_AirControl)
            {
                // The Speed animator parameter is set to the absolute value of the horizontal input.
                m_Anim.SetFloat("Speed", Mathf.Abs(move));

                // Move the character
                m_Rigidbody2D.velocity = new Vector2(move*m_MaxSpeed, m_Rigidbody2D.velocity.y);

                // If the input is moving the player right and the player is facing left...
                if (move > 0 && !m_FacingRight)
                {
                    // ... flip the player.
                    Flip();
                }
                    // Otherwise if the input is moving the player left and the player is facing right...
                else if (move < 0 && m_FacingRight)
                {
                    // ... flip the player.
                    Flip();
                }
            }
            // If the player should jump...
            if (m_Grounded && jump && m_Anim.GetBool("Ground"))
            {
                // Add a vertical force to the player.
                m_Grounded = false;
                m_Anim.SetBool("Ground", false);
                m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
            }
        }


        private void Flip()
        {
            // Switch the way the player is labelled as facing.
            m_FacingRight = !m_FacingRight;

            // Multiply the player's x local scale by -1.
            Vector3 theScale = transform.localScale;
            theScale.x *= 1;
            transform.localScale = theScale;
        }
		void OnTriggerEnter2D (Collider2D col){
		Debug.Log("Bateu");
		PlayerPrefs.SetInt ("pontuacao", pontuacao);
		if(pontuacao > PlayerPrefs.GetInt("recorde")){
			PlayerPrefs.SetInt("recorde", pontuacao);
		}
		Invoke ("GameOver", 0.1f);


		}
	void GameOver(){

		Player.SetActive (false);
		Invoke ("GameOverScreen", 2f);
		InstanciarVikingsMortos ();
	}
	void GameOverScreen(){
		GameObject _gameOverScreen = GameObject.Instantiate (gameOverScreen, gameOverScreen.transform.position, gameOverScreen.transform.rotation) as GameObject;
		Restart.SetActive (true);
		PauseButton.SetActive (false);
	}
	void InstanciarVikingsMortos()
	{
		int randX, RandY;
		GameObject _viking1 = GameObject.Instantiate (VikingMorto, transform.position, transform.rotation) as GameObject;

		
		randX = 0;
		RandY = 400;
		forca = new Vector2 (randX, RandY);
		_viking1.GetComponent<Rigidbody2D>().isKinematic = false;
		_viking1.GetComponent<Rigidbody2D>().AddForce (forca);
		_viking1.GetComponent<Rigidbody2D>().angularVelocity = 1;
		

	} 




    }

	 
//}
