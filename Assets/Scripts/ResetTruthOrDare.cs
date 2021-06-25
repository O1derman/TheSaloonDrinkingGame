using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResetTruthOrDare : MonoBehaviour
{
    public GameObject newQuestionsGameObject;
    public Button newQuestionsButton;
    public TextMeshProUGUI truthText;
    public TextMeshProUGUI dareText;

    // Start is called before the first frame update
    void Start()
    {
        newQuestionsButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        truthText.text = "Truth";
        dareText.text = "Dare";
        newQuestionsGameObject.SetActive(false);
    }
}
