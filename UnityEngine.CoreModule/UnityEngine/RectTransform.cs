namespace UnityEngine;

[NativeClass("UI::RectTransform")]
[NativeHeader("Runtime/Transform/RectTransform.h")]
public sealed class RectTransform : Transform
{
	internal enum Axis
	{
		Horizontal = 0,
		Vertical = 1,
	}

	internal enum Edge
	{
		Left = 0,
		Right = 1,
		Top = 2,
		Bottom = 3,
	}

	internal sealed class ReapplyDrivenProperties : MulticastDelegate
	{

		public ReapplyDrivenProperties(object object, IntPtr method) { }

		public override void Invoke(RectTransform driven) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static ReapplyDrivenProperties reapplyDrivenProperties; //Field offset: 0x0

	public static event ReapplyDrivenProperties reapplyDrivenProperties
	{
		[CompilerGenerated]
		 add { } //Length: 180
		[CompilerGenerated]
		 remove { } //Length: 180
	}

	public Vector2 anchoredPosition
	{
		 get { } //Length: 137
		 set { } //Length: 128
	}

	public Vector3 anchoredPosition3D
	{
		 get { } //Length: 295
		 set { } //Length: 375
	}

	public Vector2 anchorMax
	{
		 get { } //Length: 137
		 set { } //Length: 128
	}

	public Vector2 anchorMin
	{
		 get { } //Length: 137
		 set { } //Length: 128
	}

	public internal object drivenByObject
	{
		 get { } //Length: 144
		internal set { } //Length: 177
	}

	internal DrivenTransformProperties drivenProperties
	{
		internal get { } //Length: 118
		internal set { } //Length: 131
	}

	public Vector2 offsetMax
	{
		 get { } //Length: 465
		 set { } //Length: 987
	}

	public Vector2 offsetMin
	{
		 get { } //Length: 385
		 set { } //Length: 1010
	}

	public Vector2 pivot
	{
		 get { } //Length: 137
		 set { } //Length: 128
	}

	public Rect rect
	{
		 get { } //Length: 142
	}

	public Vector2 sizeDelta
	{
		 get { } //Length: 137
		 set { } //Length: 128
	}

	public RectTransform() { }

	[CompilerGenerated]
	public static void add_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	[NativeMethod("UpdateIfTransformDispatchIsDirty")]
	public void ForceUpdateRectTransforms() { }

	private static void ForceUpdateRectTransforms_Injected(IntPtr _unity_self) { }

	public Vector2 get_anchoredPosition() { }

	private static void get_anchoredPosition_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public Vector3 get_anchoredPosition3D() { }

	public Vector2 get_anchorMax() { }

	private static void get_anchorMax_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public Vector2 get_anchorMin() { }

	private static void get_anchorMin_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public object get_drivenByObject() { }

	private static IntPtr get_drivenByObject_Injected(IntPtr _unity_self) { }

	internal DrivenTransformProperties get_drivenProperties() { }

	private static DrivenTransformProperties get_drivenProperties_Injected(IntPtr _unity_self) { }

	public Vector2 get_offsetMax() { }

	public Vector2 get_offsetMin() { }

	public Vector2 get_pivot() { }

	private static void get_pivot_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public Rect get_rect() { }

	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	public Vector2 get_sizeDelta() { }

	private static void get_sizeDelta_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	private Vector2 GetParentSize() { }

	internal Rect GetRectInParentSpace() { }

	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	[CompilerGenerated]
	public static void remove_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	[RequiredByNativeCode]
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	public void set_anchoredPosition(Vector2 value) { }

	private static void set_anchoredPosition_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_anchoredPosition3D(Vector3 value) { }

	public void set_anchorMax(Vector2 value) { }

	private static void set_anchorMax_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_anchorMin(Vector2 value) { }

	private static void set_anchorMin_Injected(IntPtr _unity_self, in Vector2 value) { }

	internal void set_drivenByObject(object value) { }

	private static void set_drivenByObject_Injected(IntPtr _unity_self, IntPtr value) { }

	internal void set_drivenProperties(DrivenTransformProperties value) { }

	private static void set_drivenProperties_Injected(IntPtr _unity_self, DrivenTransformProperties value) { }

	public void set_offsetMax(Vector2 value) { }

	public void set_offsetMin(Vector2 value) { }

	public void set_pivot(Vector2 value) { }

	private static void set_pivot_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_sizeDelta(Vector2 value) { }

	private static void set_sizeDelta_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void SetInsetAndSizeFromParentEdge(Edge edge, float inset, float size) { }

	public void SetSizeWithCurrentAnchors(Axis axis, float size) { }

}

