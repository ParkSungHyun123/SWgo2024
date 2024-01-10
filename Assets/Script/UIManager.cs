using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject AlarmText;
    public GameObject Text;
    public GameObject FText;

    public bool Nomal;
    public bool Alarm;
    // Start is called before the first frame update
    void Start()
    {
        AlarmText.SetActive(false);
        Text.SetActive(false);
        FText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Nomal)
        {
            Text.SetActive(true);
        }
        else if (Alarm)
        {
            AlarmText.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FText.SetActive(true);

            if(Input.GetKeyDown(KeyCode.F)) 
            {
                SceneManager.LoadScene("Clear");
            }
        }
    }
}
