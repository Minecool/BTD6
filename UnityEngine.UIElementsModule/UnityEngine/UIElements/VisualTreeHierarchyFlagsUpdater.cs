namespace UnityEngine.UIElements;

internal class VisualTreeHierarchyFlagsUpdater : BaseVisualTreeUpdater
{
	private static readonly string s_Description; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	private uint m_Version; //Field offset: 0x28
	private uint m_LastVersion; //Field offset: 0x2C

	public virtual ProfilerMarker profilerMarker
	{
		 get { } //Length: 79
	}

	private static VisualTreeHierarchyFlagsUpdater() { }

	public VisualTreeHierarchyFlagsUpdater() { }

	private static void DirtyBoundingBoxHierarchy(VisualElement ve) { }

	protected static void DirtyHierarchy(VisualElement ve, VisualElementFlags mustDirtyFlags) { }

	protected static void DirtyParentHierarchy(VisualElement ve, VisualElementFlags flags) { }

	public virtual ProfilerMarker get_profilerMarker() { }

	protected static VisualElementFlags GetChildrenMustDirtyFlags(VisualElement ve, VersionChangeType versionChangeType) { }

	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	public virtual void Update() { }

}

