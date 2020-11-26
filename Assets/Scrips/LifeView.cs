using UnityEngine;
using UnityEngine.UI;

public class LifeView : MonoBehaviour
{
    #region Fields

    private Text _myLifeText;

    private LifeBehaviour _lifeBehaviour;

    #endregion


    #region Unity Methods

    private void Awake()
    {
        _myLifeText = GetComponent<Text>();
        _lifeBehaviour = FindObjectOfType<LifeBehaviour>();
    }

    private void OnEnable()
    {
        _lifeBehaviour.LifeChanged += LifeChangedHadler;
    }

    private void OnDisable()
    {
        _lifeBehaviour.LifeChanged -= LifeChangedHadler;
    }

    #endregion


    #region Private Methods

    private void LifeChangedHadler(float currentLife)
    {
        _myLifeText.text = currentLife.ToString();
    }

    #endregion
}
