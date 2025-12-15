using UnityEngine;

public class InGameUi : MonoBehaviour
{
    public static InGameUi Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new InGameUi();
            }
            return _instance;
        }
    }
    private static InGameUi _instance;
    public InGameUi()
    {
        _instance = this;
    }
    public MenuPanel m_MenuPanel;
    public FindOrCreateRoom m_FindOrCreateRoom;

 
}
