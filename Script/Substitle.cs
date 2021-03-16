using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Substitle : MonoBehaviour
{
    public GameObject textBox;
    public bool flag = true;
    public Rigidbody2D rb;

    bool sign = false;
    bool rock = false;
    bool down = false;
    bool start = false;
    bool end = false;
    Vector2 drop = new Vector2(0,-18);

    void Update()
    {
        if ((rb.transform.position.x >= -0.1 && rb.transform.position.x <= 0.1) && (rb.transform.position.y >= -0.1 && rb.transform.position.y <= 0.1) && start == false)
        {
            start = true;
            StartCoroutine(TheSequence());
        }
        if ((rb.transform.position.x >= 55.2 && rb.transform.position.x <= 56.35) && (rb.transform.position.y >= 25.1 && rb.transform.position.y <= 25.3) && rock == false)
        {
            rock = true;
            StartCoroutine(TheRock());
        }
        if((rb.transform.position.x >= 42.5 && rb.transform.position.x <= 43.1) && (rb.transform.position.y >= 188 && rb.transform.position.y <= 188.2) && sign == false)
        {
            sign = true;
            StartCoroutine(TheSign());
        }
        if (rb.velocity.y <= drop.y && down == false)
        {
            down = true;
            StartCoroutine(TheDrop());
        }
        if ((rb.transform.position.x >= 66.6 && rb.transform.position.x <= 78) && (rb.transform.position.y >= 190.7 && rb.transform.position.y <= 191) && end == false)
        {
            down = true;
            StartCoroutine(TheEnd());
        }
    }


    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "아이작 뉴턴은 나무에서 떨어지는 사과를 보며\n중력에 대한 고찰을 했답니다.";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "";
    }
    IEnumerator TheRock()
    {
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "가끔은 인생에 있어서 돌뿌리도 도움이 될때가 있답니다.";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "";
    }

    IEnumerator TheSign()
    {
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "도전은 인생을 흥미롭게 만들며, 도전의 극복이 인생을 의미있게 한다.\n - joshua J.Marine -";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "";
    }
    IEnumerator TheDrop()
    {
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "열정을 잃지 않고 실패해서 실패로 걸어가는 것이 성공이다.\n - Winston Churchill -";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "";
    }

    IEnumerator TheEnd()
    {
        yield return new WaitForSeconds(6);
        textBox.GetComponent<Text>().text = "모자란 엔딩이어도 슬퍼하지 말아요. \n 이미 당신은 그 자체로 성장했으니까요.";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "";
    }
}
