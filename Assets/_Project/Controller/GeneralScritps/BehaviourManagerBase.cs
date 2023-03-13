using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DM
{
    public abstract class BehaviourManagerBase : MonoBehaviour
    {
        protected DataManager dataManager;
        protected TreaManager treaManager;

        private void Start()
        {
            InitializeVariables();
        }

        private void InitializeVariables()
        {
            dataManager = DataManager.Instance;
            treaManager = TreaManager.Instance;
        }
    }
}