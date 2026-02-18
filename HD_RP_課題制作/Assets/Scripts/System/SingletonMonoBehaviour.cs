using UnityEngine;

public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
    protected static T _instance;

    public static T instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject thisGameObject = new GameObject();

                _instance = thisGameObject.AddComponent<T>();

                thisGameObject.name = "[" + typeof(T) + "]";

                DontDestroyOnLoad(thisGameObject.gameObject);

            }
            return _instance;
        }
    }

    protected virtual void Awake()
    {
        if(_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(this.gameObject);
        }
        else if(_instance != this)
        {
            Destroy(this.gameObject);
        }
    }
}
