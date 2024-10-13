using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ExitButtonController22 : MonoBehaviour
{
    [SerializeField] private Button _exitButton2;

    private void Awake()
    {
        void FuncExit2()
        {
            Exit2();
        }

        FuncExit2();
    }

    private void Exit2()
    {
        void Func2()
        {
            _exitButton2.onClick.AddListener(Application.Quit);
        }

        Func2();
    }
}
