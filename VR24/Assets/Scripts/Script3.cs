using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.EventSystems;

public class Script3 : MonoBehaviour
{
    public Text nm;
    public Text value;
    public Text degree;
    public string jsonURL;
    public Jsonclass jsnData;

    void Start()
    {
        StartCoroutine(getData());
    }

    IEnumerator getData()
    {
        Debug.Log("��������...");
        var uwr = new UnityWebRequest(jsonURL);
        uwr.method = UnityWebRequest.kHttpVerbGET;
        var resultFile = Path.Combine(Application.persistentDataPath, "result.json");
        var dh = new DownloadHandlerFile(resultFile);
        dh.removeFileOnAbort = true;
        uwr.downloadHandler = dh;
        yield return uwr.SendWebRequest();
        Debug.Log("���� �������� �� ����:" + resultFile);
        jsnData = JsonUtility.FromJson<Jsonclass>(File.ReadAllText(Application.persistentDataPath + "/result.json"));
        nm.text = jsnData.Name.ToString();
        value.text = jsnData.Value.ToString();
        degree.text = jsnData.Degree.ToString();
        yield return StartCoroutine(getData());
    }
    [System.Serializable]

    public class Jsonclass
    {
        public string Name;
        public int Value;
        public string Degree;
    }
}
