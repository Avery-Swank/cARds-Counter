using UnityEngine;
using UnityEngine.UI;

public class RunningCount : MonoBehaviour {

    private string m_description = "Running Count: ";
    private Text m_descriptionText;

    public static int m_count;

	void Start () {
        m_descriptionText = GetComponent<Text>();
        m_count = 0;
	}
	
	void Update () {
        m_descriptionText.text = m_description + m_count;
	}

    public static void PlusValue(int value)
    {
        m_count += value;
    }
}
