using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class LoadingPanel : IPanel
{
    [SerializeField] private TMP_Text loadingText;
    [SerializeField] private Slider loadingBar;

    protected override void Initialise()
    {
        base.Initialise();

        Show();
    }

    protected override void OnShow()
    {
        base.OnShow();
    }
}
