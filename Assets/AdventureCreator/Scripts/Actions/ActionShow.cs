using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace AC
{
    [System.Serializable]

public class ActionShow : Action
{
   
public GameObject uiPanel;
public bool hideInstead = false;
public ActionShow()
{
    this.isDisplayed = true;
    category = ActionCategory.Custom;
    title = "Show UI Panel"; 
}

public override float Run()
{
    if (uiPanel != null)
    {
        uiPanel.SetActive(!hideInstead);
    }
    return 0f;
}
public override void Skip()
{
    Run();
}
    #if UNITY_EDITOR

        public override void ShowGUI()
        {
            uiPanel = (GameObject)EditorGUILayout.ObjectField(
                "UI Panel:",
                uiPanel,
                typeof(GameObject),
                true
            );

            hideInstead = EditorGUILayout.Toggle("Hide:", hideInstead);

            AfterRunningOption();
        }

#endif
    }
}
