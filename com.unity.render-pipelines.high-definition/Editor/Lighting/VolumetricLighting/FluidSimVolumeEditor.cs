using UnityEditorInternal;
using UnityEngine.Experimental.Rendering.HDPipeline;

namespace UnityEditor.Experimental.Rendering.HDPipeline
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(FluidSimVolume))]
    public class FluidSimVolumeEditor : Editor
    {
        internal const EditMode.SceneViewEditMode k_EditShape = EditMode.SceneViewEditMode.ReflectionProbeBox;
        internal const EditMode.SceneViewEditMode k_EditBlend = EditMode.SceneViewEditMode.GridBox;

        static HierarchicalBox s_ShapeBox;
        internal static HierarchicalBox s_BlendBox;

        void OnEnable()
        {
            //m_SerializedDensityVolume = new SerializedDensityVolume(serializedObject);

            if (s_ShapeBox == null || s_ShapeBox.Equals(null))
            {
                s_ShapeBox = new HierarchicalBox(DensityVolumeUI.Styles.k_GizmoColorBase, DensityVolumeUI.Styles.k_BaseHandlesColor);
                s_ShapeBox.monoHandle = false;
            }
            if (s_BlendBox == null || s_BlendBox.Equals(null))
            {
                s_BlendBox = new HierarchicalBox(DensityVolumeUI.Styles.k_GizmoColorBase, InfluenceVolumeUI.k_HandlesColor, parent: s_ShapeBox);
            }
        }

        public override void OnInspectorGUI()
        {
            //serializedObject.Update();

            //FluidSimVolumeUI.Inspector.Draw(m_SerializedDensityVolume, this);

            //m_SerializedDensityVolume.Apply();
        }
    }
}
