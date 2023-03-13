using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DM
{
    public class IntroductionManager : MonoBehaviour
    {
        private DataManager dataManager;
        private TreaManager treaManager;

        private void Start()
        {
            InitializeVariables();
            
        }

        [ContextMenu("ExecuteTestDialog")]
        private void ExecuteTestDialog()
        {
            treaManager.ReproduceTreaDialog(dataManager.dialogSOTest);
        }

        private void InitializeVariables()
        {
            dataManager = DataManager.Instance;
            treaManager = TreaManager.Instance;
        }
    }
}
