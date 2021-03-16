using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class apple : MonoBehaviour
{
    [Range(0.1f,2f)]
    public float power = 10f;
    public Rigidbody2D rb;

    public float p1 = -5.7f, p2 = 1.05f, p3 = 0f;
    public float v1 = 0, v2 = 0;

    public Vector2 minPower;
    public Vector2 maxPower;

    public bool stop = false;
    Vector2 prePos;
    Vector2 startPos;
    Vector2 endPos;

    public VideoPlayer Ending;
    public RawImage End;
    bool endflag = false;

    drawLine dl;

    public bool over = false;

    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;
    Vector3 respondPoint = new Vector3(0f, 2, 0);
    bool first = false;

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public float sk;

    float speed;
    public float modifiedScale;
    public void Start()
    {
        cam = Camera.main;
        dl = GetComponent<drawLine>();
        LoadData();
        spriteRenderer = rb.gameObject.GetComponent<SpriteRenderer>();
        if (sk == 1)
        {
            spriteRenderer.sprite = newSprite;
        }
        rb.transform.position = new Vector3(p1, p2, p3);
        rb.velocity = new Vector2(v1, v2);
        dl.endLine();
        prePos = rb.position;
        startPos = rb.position;
        endPos = rb.position;
    }
    public void Update()
    {
        Time.timeScale = modifiedScale;
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
            p1 = rb.transform.position.x;
            p2 = rb.transform.position.y;
            p3 = rb.transform.position.z;
            v1 = rb.velocity.x;
            v2 = rb.velocity.y;


        startPoint = rb.transform.position;
        speed = rb.velocity.magnitude;
        if (speed < 0.1) 
        {
            rb.velocity = new Vector3(0, 0, 0);
            stop = true;
        }
        prePos = endPos;
        if (stop)
        {
            if ((rb.transform.position.x >= 66.6 && rb.transform.position.x <= 78) && (rb.transform.position.y >= 190.7 && rb.transform.position.y <= 191) && endflag == false)
            {
                Ending.Play();
                float alpha = 1.0f; //1 is opaque, 0 is transparent
                Color currColor = End.color;
                currColor.a = alpha;
                End.color = currColor;
                endflag = true;
            }
            if (Input.GetMouseButton(0))
            {
                Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                startPoint.z = 15;
                dl.RenderLine(startPoint, currentPoint);
            }

            if (Input.GetMouseButtonUp(0))
            {
                endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                endPoint.z = 15;

                dl.endLine();

                force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
                rb.AddForce(force * power, ForceMode2D.Impulse);
            }
            stop = false;
        }
        if(rb.transform.position.y <= -3)
        {
            
            rb.transform.position = respondPoint;
            rb.velocity = new Vector3(0, 0, 0);
            over = true;
        }
        endPos = startPos;
        startPos = rb.position;
    }
    public void SaveData()
    {
        PlayerPrefs.SetFloat("floata", p1);
        PlayerPrefs.SetFloat("floatb", p2);
        PlayerPrefs.SetFloat("floatc", p3);
        PlayerPrefs.SetFloat("floatav", v1);
        PlayerPrefs.SetFloat("floatbv", v2);
        PlayerPrefs.Save();
    }
    public void LoadData()
    {
        p1 = PlayerPrefs.GetFloat("floata");
        p2 = PlayerPrefs.GetFloat("floatb");
        p3 = PlayerPrefs.GetFloat("floatc");
        v1 = PlayerPrefs.GetFloat("floatav");
        v2 = PlayerPrefs.GetFloat("floatbv");
        sk = PlayerPrefs.GetFloat("skin");
    }
}