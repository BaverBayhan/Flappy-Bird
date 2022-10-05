using UnityEngine;
using UnityEngine.UI;

public class score_script : MonoBehaviour
{
    private GameObject text;
    private Text text_component;
    private void Start()
    {
        text=GameObject.FindWithTag("text");
        text_component=text.GetComponent<Text>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int current_score = int.Parse(text_component.text);
        current_score+=1;
        text_component.text=current_score.ToString();
    }
}
