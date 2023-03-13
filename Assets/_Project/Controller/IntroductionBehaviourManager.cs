using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DM
{
    public class IntroductionBehaviourManager : BehaviourManagerBase
    {
        [ContextMenu("ExecuteTestDialog")]
        private void ExecuteTestDialog()
        {
            treaManager.ReproduceTreaDialog(dataManager.dialogSOTest);
        }
    }
}
