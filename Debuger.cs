using UnityEngine;

public class Debuger : MonoBehaviour
{
    public static Debuger instance;
    [SerializeField] bool isInDebugMode = false;
    void Awake()
    {
        instance = this;
    }
    public bool getDebugmode()
    {
        return isInDebugMode;
    }

    public void DebugMessage(string input)
    {
        if (!getDebugmode())
        {
            Debug.LogError("[ERROR] Debugmode isn't enabled!");
            return;
        }
        Debug.Log("[INFO] " + input);
    }

    public void ErrorMessage(string input)
    {
        if (!getDebugmode())
        {
            Debug.LogError("[ERROR] Debugmode isn't enabled!");
            return;
        }
        Debug.LogError("[ERROR] " + input);
    }
}
