namespace UnityEngine;

[NativeHeader("Runtime/Transform/Transform.h")]
[NativeHeader("Configuration/UnityConfigure.h")]
[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
[RequiredByNativeCode]
public class Transform : Component, IEnumerable
{
	private class Enumerator : IEnumerator
	{
		private Transform outer; //Field offset: 0x10
		private int currentIndex; //Field offset: 0x18

		public override object Current
		{
			 get { } //Length: 76
		}

		internal Enumerator(Transform outer) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}


	public int childCount
	{
		[NativeMethod("GetChildrenCount")]
		 get { } //Length: 51
	}

	[NativeConditional("UNITY_EDITOR")]
	internal bool constrainProportionsScale
	{
		internal get { } //Length: 51
		internal set { } //Length: 66
	}

	public Vector3 eulerAngles
	{
		 get { } //Length: 208
		 set { } //Length: 142
	}

	public Vector3 forward
	{
		 get { } //Length: 195
		 set { } //Length: 99
	}

	[NativeProperty("HasChangedDeprecated")]
	public bool hasChanged
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int hierarchyCapacity
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int hierarchyCount
	{
		 get { } //Length: 51
	}

	public Vector3 localEulerAngles
	{
		 get { } //Length: 208
		 set { } //Length: 142
	}

	public Vector3 localPosition
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public Quaternion localRotation
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public Vector3 localScale
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public Matrix4x4 localToWorldMatrix
	{
		 get { } //Length: 87
	}

	public Vector3 lossyScale
	{
		[NativeMethod("GetWorldScaleLossy")]
		 get { } //Length: 77
	}

	public Transform parent
	{
		 get { } //Length: 51
		 set { } //Length: 186
	}

	internal Transform parentInternal
	{
		internal get { } //Length: 51
		internal set { } //Length: 69
	}

	public Vector3 position
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public Vector3 right
	{
		 get { } //Length: 195
		 set { } //Length: 176
	}

	public Transform root
	{
		 get { } //Length: 51
	}

	public Quaternion rotation
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	[NativeConditional("UNITY_EDITOR")]
	internal RotationOrder rotationOrder
	{
		internal get { } //Length: 51
		internal set { } //Length: 64
	}

	public Vector3 up
	{
		 get { } //Length: 195
		 set { } //Length: 176
	}

	public Matrix4x4 worldToLocalMatrix
	{
		 get { } //Length: 87
	}

	protected Transform() { }

	[FreeFunction("DetachChildren", HasExplicitThis = True)]
	public void DetachChildren() { }

	public Transform Find(string n) { }

	[Obsolete("FindChild has been deprecated. Use Find instead (UnityUpgradable) -> Find([mscorlib] System.String)", False)]
	public Transform FindChild(string n) { }

	[FreeFunction]
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	[NativeMethod("GetChildrenCount")]
	public int get_childCount() { }

	internal bool get_constrainProportionsScale() { }

	public Vector3 get_eulerAngles() { }

	public Vector3 get_forward() { }

	public bool get_hasChanged() { }

	public int get_hierarchyCapacity() { }

	public int get_hierarchyCount() { }

	public Vector3 get_localEulerAngles() { }

	public Vector3 get_localPosition() { }

	private void get_localPosition_Injected(out Vector3 ret) { }

	public Quaternion get_localRotation() { }

	private void get_localRotation_Injected(out Quaternion ret) { }

	public Vector3 get_localScale() { }

	private void get_localScale_Injected(out Vector3 ret) { }

	public Matrix4x4 get_localToWorldMatrix() { }

	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	[NativeMethod("GetWorldScaleLossy")]
	public Vector3 get_lossyScale() { }

	private void get_lossyScale_Injected(out Vector3 ret) { }

	public Transform get_parent() { }

	internal Transform get_parentInternal() { }

	public Vector3 get_position() { }

	private void get_position_Injected(out Vector3 ret) { }

	public Vector3 get_right() { }

	public Transform get_root() { }

	public Quaternion get_rotation() { }

	private void get_rotation_Injected(out Quaternion ret) { }

	internal RotationOrder get_rotationOrder() { }

	public Vector3 get_up() { }

	public Matrix4x4 get_worldToLocalMatrix() { }

	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	[FreeFunction("GetChild", HasExplicitThis = True)]
	[NativeThrows]
	public Transform GetChild(int index) { }

	[NativeMethod("GetChildrenCount")]
	[Obsolete("warning use Transform.childCount instead (UnityUpgradable) -> Transform.childCount", False)]
	public int GetChildCount() { }

	public override IEnumerator GetEnumerator() { }

	internal Vector3 GetLocalEulerAngles(RotationOrder order) { }

	private void GetLocalEulerAngles_Injected(RotationOrder order, out Vector3 ret) { }

	public void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation) { }

	private Transform GetParent() { }

	public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation) { }

	private Transform GetRoot() { }

	[NativeConditional("UNITY_EDITOR")]
	[NativeMethod("GetRotationOrder")]
	internal int GetRotationOrderInternal() { }

	public int GetSiblingIndex() { }

	[FreeFunction("GetHierarchyCapacity", HasExplicitThis = True)]
	private int internal_getHierarchyCapacity() { }

	[FreeFunction("GetHierarchyCount", HasExplicitThis = True)]
	private int internal_getHierarchyCount() { }

	[FreeFunction("Internal_LookAt", HasExplicitThis = True)]
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	[FreeFunction("SetHierarchyCapacity", HasExplicitThis = True)]
	private void internal_setHierarchyCapacity(int value) { }

	public Vector3 InverseTransformDirection(float x, float y, float z) { }

	public Vector3 InverseTransformDirection(Vector3 direction) { }

	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	public void InverseTransformDirections(Span<Vector3> directions) { }

	public void InverseTransformDirections(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections) { }

	internal void InverseTransformDirections(Vector3* directions, int count, Vector3* transformedDirections, int transformedCount) { }

	public Vector3 InverseTransformPoint(float x, float y, float z) { }

	public Vector3 InverseTransformPoint(Vector3 position) { }

	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public void InverseTransformPoints(Span<Vector3> positions) { }

	public void InverseTransformPoints(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions) { }

	internal void InverseTransformPoints(Vector3* positions, int count, Vector3* transformedPositions, int transformedCount) { }

	public Vector3 InverseTransformVector(float x, float y, float z) { }

	public Vector3 InverseTransformVector(Vector3 vector) { }

	private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	public void InverseTransformVectors(Span<Vector3> vectors) { }

	public void InverseTransformVectors(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors) { }

	internal void InverseTransformVectors(Vector3* vectors, int count, Vector3* transformedVectors, int transformedCount) { }

	[FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = True)]
	public bool IsChildOf(Transform parent) { }

	[NativeConditional("UNITY_EDITOR")]
	private bool IsConstrainProportionsScale() { }

	[FreeFunction("IsNonUniformScaleTransform", HasExplicitThis = True)]
	[NativeConditional("UNITY_EDITOR")]
	internal bool IsNonUniformScaleTransform() { }

	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	public void LookAt(Transform target, Vector3 worldUp) { }

	public void LookAt(Vector3 worldPosition) { }

	public void LookAt(Transform target) { }

	[NativeMethod("MoveAfterSiblingInternal")]
	internal void MoveAfterSibling(Transform transform, bool notifyEditorAndMarkDirty) { }

	public void Rotate(Vector3 eulers) { }

	public void Rotate(Vector3 eulers, Space relativeTo) { }

	public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo) { }

	public void Rotate(float xAngle, float yAngle, float zAngle) { }

	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	public void Rotate(Vector3 axis, float angle) { }

	[Obsolete("warning use Transform.Rotate instead.")]
	public void RotateAround(Vector3 axis, float angle) { }

	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	private void RotateAround_Injected(ref Vector3 axis, float angle) { }

	[NativeMethod("RotateAround")]
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	[Obsolete("warning use Transform.Rotate instead.")]
	public void RotateAroundLocal(Vector3 axis, float angle) { }

	private void RotateAroundLocal_Injected(ref Vector3 axis, float angle) { }

	[NativeConditional("UNITY_EDITOR")]
	internal void SendTransformChangedScale() { }

	internal void set_constrainProportionsScale(bool value) { }

	public void set_eulerAngles(Vector3 value) { }

	public void set_forward(Vector3 value) { }

	public void set_hasChanged(bool value) { }

	public void set_hierarchyCapacity(int value) { }

	public void set_localEulerAngles(Vector3 value) { }

	public void set_localPosition(Vector3 value) { }

	private void set_localPosition_Injected(ref Vector3 value) { }

	public void set_localRotation(Quaternion value) { }

	private void set_localRotation_Injected(ref Quaternion value) { }

	public void set_localScale(Vector3 value) { }

	private void set_localScale_Injected(ref Vector3 value) { }

	public void set_parent(Transform value) { }

	internal void set_parentInternal(Transform value) { }

	public void set_position(Vector3 value) { }

	private void set_position_Injected(ref Vector3 value) { }

	public void set_right(Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	private void set_rotation_Injected(ref Quaternion value) { }

	internal void set_rotationOrder(RotationOrder value) { }

	public void set_up(Vector3 value) { }

	public void SetAsFirstSibling() { }

	public void SetAsLastSibling() { }

	[NativeConditional("UNITY_EDITOR")]
	private void SetConstrainProportionsScale(bool isLinked) { }

	internal void SetLocalEulerAngles(Vector3 euler, RotationOrder order) { }

	private void SetLocalEulerAngles_Injected(ref Vector3 euler, RotationOrder order) { }

	[NativeConditional("UNITY_EDITOR")]
	internal void SetLocalEulerHint(Vector3 euler) { }

	private void SetLocalEulerHint_Injected(ref Vector3 euler) { }

	public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation) { }

	private void SetLocalPositionAndRotation_Injected(ref Vector3 localPosition, ref Quaternion localRotation) { }

	public void SetParent(Transform p) { }

	[FreeFunction("SetParent", HasExplicitThis = True)]
	public void SetParent(Transform parent, bool worldPositionStays) { }

	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	[NativeConditional("UNITY_EDITOR")]
	[NativeMethod("SetRotationOrder")]
	internal void SetRotationOrderInternal(RotationOrder rotationOrder) { }

	public void SetSiblingIndex(int index) { }

	public Vector3 TransformDirection(float x, float y, float z) { }

	public Vector3 TransformDirection(Vector3 direction) { }

	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	public void TransformDirections(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections) { }

	internal void TransformDirections(Vector3* directions, int count, Vector3* transformedDirections, int transformedCount) { }

	public void TransformDirections(Span<Vector3> directions) { }

	public Vector3 TransformPoint(Vector3 position) { }

	public Vector3 TransformPoint(float x, float y, float z) { }

	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public void TransformPoints(Span<Vector3> positions) { }

	public void TransformPoints(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions) { }

	internal void TransformPoints(Vector3* positions, int count, Vector3* transformedPositions, int transformedCount) { }

	public Vector3 TransformVector(Vector3 vector) { }

	public Vector3 TransformVector(float x, float y, float z) { }

	private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	public void TransformVectors(Span<Vector3> vectors) { }

	public void TransformVectors(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors) { }

	internal void TransformVectors(Vector3* vectors, int count, Vector3* transformedVectors, int transformedCount) { }

	public void Translate(Vector3 translation) { }

	public void Translate(Vector3 translation, Transform relativeTo) { }

	public void Translate(float x, float y, float z) { }

	public void Translate(float x, float y, float z, Space relativeTo) { }

	public void Translate(float x, float y, float z, Transform relativeTo) { }

	public void Translate(Vector3 translation, Space relativeTo) { }

}

