﻿using UnityEditor;

namespace AimIK.Editor
{
    /// <summary>
    /// Check that you don't add AimIKBehaviourBase class to a GameObject
    /// </summary>
    [CustomEditor(typeof(AimIKBehaviourBase))]
    internal class DontAddAimIKBehaviourBase : UnityEditor.Editor
    {
        void OnEnable()
        {
            EditorUtility.DisplayDialog("Can't add the Base class", "Can't add component 'AimIKBehaviourBase' to GameObject."
            + "You must add one of the 'AimIKBehaviour' or 'AimIKBehaviour2D' components to it.", "Cancel");
            DestroyImmediate((AimIKBehaviourBase)this.target);
        }
    }
}
