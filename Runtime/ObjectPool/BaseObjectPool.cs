using UnityEngine;
using UnityEngine.Pool;

namespace long18.ExtensionsCore.ObjectPool
{
    public abstract class BaseObjectPool<TItem> : MonoBehaviour where TItem : MonoBehaviour
    {
        [SerializeField] protected TItem _prefab;
        [SerializeField] protected int _defaultPoolSize;
        [SerializeField] protected int _maxPoolSize;
        [SerializeField] protected bool _collectionCheck;
        
        // Performane is better if this is false
        [Tooltip("If order is needed item will be set at first child when being getted")]
        [SerializeField] private bool _isOrderNeeded;

        private IObjectPool<TItem> _pool;

        protected virtual void Awake()
        {
            _pool = new ObjectPool<TItem>(OnCreateItem, OnGetItem, OnReleaseItem,
                OnDestroyItem,_collectionCheck,_defaultPoolSize,_maxPoolSize);
        }

        protected virtual TItem OnCreateItem()
        {
            var item = Instantiate(_prefab, transform);
            return item;
        }

        protected virtual void OnGetItem(TItem item)
        {
            if (_isOrderNeeded)
                item.transform.SetAsFirstSibling();
            item.gameObject.SetActive(true);
        }

        protected virtual void OnReleaseItem(TItem item)
        {
            item.gameObject.SetActive(false);
        }

        protected virtual void OnDestroyItem(TItem item)
            => Destroy(item.gameObject);

        public virtual TItem GetItem() => _pool.Get();

        public virtual void ReleaseItem(TItem item)
        {
            if (item == null || !item.gameObject.activeInHierarchy)
                return;

            _pool.Release(item);
        }

        public virtual void ReleaseAll() => _pool.Clear();
    }
}
