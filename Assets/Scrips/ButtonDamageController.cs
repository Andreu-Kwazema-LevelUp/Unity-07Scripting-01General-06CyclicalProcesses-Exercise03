using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonDamageController : MonoBehaviour, IPointerClickHandler
{
    #region Fields

    [SerializeField]
    private float _damage = 10;

    private LifeBehaviour _lifeBehaviour;

    #endregion


    #region Unity Methods

    private void Awake()
    {
        _lifeBehaviour = FindObjectOfType<LifeBehaviour>();
    }

    #endregion


    #region Interface Methods

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        _lifeBehaviour.TakeDamage(_damage);
    }

    #endregion
}
