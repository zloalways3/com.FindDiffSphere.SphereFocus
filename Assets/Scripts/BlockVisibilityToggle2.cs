using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BlockVisibilityToggle2 : MonoBehaviour
{
    public event Action OnBlocksToggled2;

    [FormerlySerializedAs("_currentBlocks")][SerializeField] private List<GameObject> blocksToHide;
    [FormerlySerializedAs("_targetBlocks")][SerializeField] private List<GameObject> blocksToShow;
    [SerializeField] private Button toggleButton;

    private void Awake()
    {
        AddListeners2();
    }

    private void AddListeners2()
    {
        toggleButton.onClick.AddListener(ToggleBlocksVisibility2);
    }

    private void ToggleBlocksVisibility2()
    {
        void Func2()
        {
            HideBlocks2();
            ShowBlocks2();

            OnBlocksToggled2?.Invoke();
        }

        Func2();
    }

    private void HideBlocks2()
    {
        void Func2()
        {
            foreach (GameObject block2 in blocksToHide)
            {
                block2.SetActive(false);
            }
        }

        Func2();
    }
    
    void ShowBlocks2()
    {
        void Func2()
        {
            foreach (GameObject block3 in blocksToShow)
            {
                block3.SetActive(true);
            }
        }

        Func2();
    }
}
