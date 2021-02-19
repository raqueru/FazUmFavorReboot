using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMov : MonoBehaviour
{
    public Animator Animator;
    public AudioSource walk;

    

    public DialogueManager Dialogue;
    public float Movespeed;
    public float Jumpforce;
    public bool IsGrounded = false;
    void Start()
    {

      //  walk =GameObject.FindGameObjectWithTag("audio").GetComponent<AudioSource>();
    }

    void Update()
    {
        Jump();

        Walk();
        if (IsGrounded==false)  Animator.SetBool("isjumping", true);
        else  Animator.SetBool("isjumping", false);
           



    }
    void Jump()
    {
        if (Dialogue.DialogueOn == false)
        {
            //            if(Cutscene.cutscene==false){
            if (Input.GetButtonDown("Jump") && IsGrounded == true)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Jumpforce), ForceMode2D.Impulse);
                 

            }
           

             

        }

    }

    void Walk()
    {
        if (Dialogue.DialogueOn == false)
        {

            float mov = (Input.GetAxis("Horizontal setas"));
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal setas"), 0f, 0f);
            if (mov < 0)
            {
                transform.rotation = new Quaternion(0, 180, 0, 0);
                 
                
            }
            else if (mov > 0)
            {
                transform.rotation = new Quaternion(0, 0, 0, 0);
                 
            }

            transform.position += movement * Time.deltaTime * Movespeed;
             
            // if(Cutscene.cutscene==false){
            if (Input.GetButtonDown("Horizontal setas"))
            {

                Animator.SetBool("IsWalking", true);
                if(IsGrounded==true)
                walk.Play();
 
            }
            else if (Input.GetButtonUp("Horizontal setas"))
            {
                Animator.SetBool("IsWalking", false);
                walk.Stop();
            }
             
             
                 
        }
        else  {Animator.SetBool("IsWalking", false);
         walk.Stop();}

    }
 public void PlayPassos()
    {
        if(IsGrounded == true)
        {
            walk.pitch = Random.Range(0.7f, 1.3f);
            walk.Play();
        }
 

}
}
