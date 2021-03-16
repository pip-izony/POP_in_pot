using UnityEngine;

public class Fade : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    bool flag = false;
    // Update is called once per frame

    void Update()
    {
        if (flag)
        {
            if (rb.transform.position.y <= -2.3)
            {
                flag = false;
                die(1);
            }
        }
        if(rb.transform.position.y > -2.3)
        {
            flag = true;
        }
    }

    public void die(int index)
    {
        animator.SetBool("FadeIn", true);
    }
}
