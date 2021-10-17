//------------------------------
// Author: yangchengchao
// Data:   2021
//------------------------------

using UnityEngine;
using UnityEngine.UI;

public class GameRoot : MonoBehaviour
{
    public AudioSource audioSource;

    private Transform canvas;
    private GameObject bgGo;
    private Button createAB_Btn;
    private Text time;
    private float waitTime;

    private void Awake()
    {
        canvas = GetComponentInChildren<Canvas>().transform;
        GetComponentInChildren<Button>().onClick.AddListener(() =>
        {
            //TODO 改为AB加载
            //bgGo = GameObject.Instantiate<GameObject>(Resources.Load<GameObject>("BG"));

            bgGo.transform.SetParent(canvas, false);
            time = bgGo.GetComponentInChildren<Text>();
            waitTime = 3.0f;
            time.text = Mathf.FloorToInt(waitTime).ToString();
        });
    }

    private void Update()
    {
        if (bgGo == null || waitTime < 0f) return;

        waitTime -= Time.deltaTime;
        time.text = Mathf.RoundToInt(waitTime).ToString();
        if(waitTime <= 0)
        {
            Destroy(bgGo);
            bgGo = null; 
        }
    }
}
