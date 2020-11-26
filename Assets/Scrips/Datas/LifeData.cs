using UnityEngine;

[CreateAssetMenu(fileName = "LifeData", menuName = "Scriptable Objecte/Life Data")]
public class LifeData : ScriptableObject
{
    #region Propierties

    public int MaxLife { get => _maxLife; }

    public int CurrentLife { get => _currentLife; set => _currentLife = value; }

    #endregion


    #region Fields

    [SerializeField]
    private int _maxLife = 0;
    
    [SerializeField]
    private int _currentLife = 0;

    #endregion

    //
}
