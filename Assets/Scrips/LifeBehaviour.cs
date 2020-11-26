using UnityEngine;

public class LifeBehaviour : MonoBehaviour
{
    #region Propierties

    public float CurrentLife { get; private set; }

    #endregion


    #region Fields

    [SerializeField]
    private float _maxLife;

    #endregion


    #region Events

    public delegate void LifeChangedHandler(float currentLife);

    public event LifeChangedHandler LifeChanged;

    #endregion


    #region Unity Methods


    private void Start()
    {
        CurrentLife = _maxLife;
        OnLifeChange(CurrentLife);
    }

    #endregion


    #region General Methods

    public void TakeDamage(float value)
    {
        if (CurrentLife > 0)
        {
            CurrentLife = Mathf.Max(CurrentLife - value, 0);

            OnLifeChange(CurrentLife);
        }
    }

    public void TakeLife(float value)
    {
        if (CurrentLife < _maxLife)
        {
            CurrentLife = Mathf.Min(CurrentLife + value, _maxLife);

            OnLifeChange(CurrentLife);
        }
    }

    #endregion


    #region Event Methods

    private void OnLifeChange(float currentLife)
    {
        LifeChanged?.Invoke(currentLife);
    }

    #endregion


    //variasblkes
    //propiedades
    //pro internal privado
    //
}
