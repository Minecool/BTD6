namespace UnityEngine;

[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
[NativeHeader("Runtime/GameCode/CloneObject.h")]
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[RequiredByNativeCode(GenerateProxy = True)]
public class object
{
	internal static int OffsetOfInstanceIDInCPlusPlusObject; //Field offset: 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null."; //Field offset: 0x0
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."; //Field offset: 0x0
	private IntPtr m_CachedPtr; //Field offset: 0x10

	public HideFlags hideFlags
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public string name
	{
		 get { } //Length: 100
		 set { } //Length: 115
	}

	private static Object() { }

	public Object() { }

	private static void CheckNullArgument(object arg, string message) { }

	private static bool CompareBaseObjects(object lhs, object rhs) { }

	[NativeMethod(Name = "CurrentThreadIsMainThread", IsFreeFunction = True, IsThreadSafe = True)]
	private static bool CurrentThreadIsMainThread() { }

	[ExcludeFromDocs]
	public static void Destroy(object obj) { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = True, ThrowsException = True)]
	public static void Destroy(object obj, float t) { }

	[ExcludeFromDocs]
	public static void DestroyImmediate(object obj) { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = True, ThrowsException = True)]
	public static void DestroyImmediate(object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocs]
	[Obsolete("use Object.Destroy instead.")]
	public static void DestroyObject(object obj) { }

	[Obsolete("use Object.Destroy instead.")]
	public static void DestroyObject(object obj, float t) { }

	[NativeMethod(Name = "UnityEngineObjectBindings::DoesObjectWithInstanceIDExist", IsFreeFunction = True, IsThreadSafe = True)]
	internal static bool DoesObjectWithInstanceIDExist(int instanceID) { }

	[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = True)]
	public static void DontDestroyOnLoad(object target) { }

	private void EnsureRunningOnMainThread() { }

	public virtual bool Equals(object other) { }

	public static T FindAnyObjectByType() { }

	public static T FindAnyObjectByType(FindObjectsInactive findObjectsInactive) { }

	public static object FindAnyObjectByType(Type type) { }

	public static object FindAnyObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	public static object FindFirstObjectByType(Type type) { }

	public static object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	public static T FindFirstObjectByType(FindObjectsInactive findObjectsInactive) { }

	public static T FindFirstObjectByType() { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
	[VisibleToOtherModules]
	internal static object FindObjectFromInstanceID(int instanceID) { }

	public static T FindObjectOfType() { }

	public static T FindObjectOfType(bool includeInactive) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public static object FindObjectOfType(Type type, bool includeInactive) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public static object FindObjectOfType(Type type) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectsByType")]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	public static T[] FindObjectsByType(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	public static Object[] FindObjectsByType(Type type, FindObjectsSortMode sortMode) { }

	public static T[] FindObjectsByType(FindObjectsSortMode sortMode) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsOfType(Type type, bool includeInactive) { }

	public static Object[] FindObjectsOfType(Type type) { }

	public static T[] FindObjectsOfType() { }

	public static T[] FindObjectsOfType(bool includeInactive) { }

	[Obsolete("Please use Resources.FindObjectsOfTypeAll instead")]
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfTypeIncludingAssets")]
	[Obsolete("use Resources.FindObjectsOfTypeAll instead.")]
	public static Object[] FindObjectsOfTypeIncludingAssets(Type type) { }

	[Obsolete("warning use Object.FindObjectsByType instead.")]
	public static Object[] FindSceneObjectsOfType(Type type) { }

	[FreeFunction("UnityEngineObjectBindings::ForceLoadFromInstanceID")]
	[VisibleToOtherModules]
	internal static object ForceLoadFromInstanceID(int instanceID) { }

	public HideFlags get_hideFlags() { }

	public string get_name() { }

	private IntPtr GetCachedPtr() { }

	public virtual int GetHashCode() { }

	public int GetInstanceID() { }

	[FreeFunction("UnityEngineObjectBindings::GetName")]
	private static string GetName(object obj) { }

	[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = True, IsThreadSafe = True)]
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Transform parent) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Scene scene) { }

	public static T Instantiate(T original) { }

	public static T Instantiate(T original, Vector3 position, Quaternion rotation) { }

	public static T Instantiate(T original, Vector3 position, Quaternion rotation, Transform parent) { }

	public static T Instantiate(T original, Transform parent) { }

	public static T Instantiate(T original, Transform parent, bool worldPositionStays) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Transform parent, bool instantiateInWorldSpace) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, Vector3 position, Quaternion rotation) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, Transform parent) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Vector3 position, Quaternion rotation) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Transform parent, Vector3 position, Quaternion rotation) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Transform parent, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Transform parent) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, Transform parent, Vector3 position, Quaternion rotation) { }

	[NativeMethod(Name = "CloneObject", IsFreeFunction = True, ThrowsException = True)]
	private static object Internal_CloneSingle(object data) { }

	[FreeFunction("CloneObject")]
	private static object Internal_CloneSingleWithParent(object data, Transform parent, bool worldPositionStays) { }

	[FreeFunction("CloneObjectToScene")]
	private static object Internal_CloneSingleWithScene(object data, Scene scene) { }

	private static object Internal_CloneSingleWithScene_Injected(object data, ref Scene scene) { }

	[FreeFunction("InstantiateAsyncObjects")]
	private static AsyncInstantiateOperation Internal_InstantiateAsyncWithParent(object original, int count, Transform parent, IntPtr positions, int positionsCount, IntPtr rotations, int rotationsCount) { }

	[FreeFunction("InstantiateObject")]
	private static object Internal_InstantiateSingle(object data, Vector3 pos, Quaternion rot) { }

	private static object Internal_InstantiateSingle_Injected(object data, ref Vector3 pos, ref Quaternion rot) { }

	[FreeFunction("InstantiateObject")]
	private static object Internal_InstantiateSingleWithParent(object data, Transform parent, Vector3 pos, Quaternion rot) { }

	private static object Internal_InstantiateSingleWithParent_Injected(object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }

	private static bool IsNativeObjectAlive(object o) { }

	[FreeFunction("UnityEngineObjectBindings::IsPersistent")]
	internal static bool IsPersistent(object obj) { }

	[FreeFunction("UnityEngineObjectBindings::MarkObjectDirty", HasExplicitThis = True)]
	internal void MarkDirty() { }

	public static bool op_Equality(object x, object y) { }

	public static bool op_Implicit(object exists) { }

	public static bool op_Inequality(object x, object y) { }

	public void set_hideFlags(HideFlags value) { }

	public void set_name(string value) { }

	[FreeFunction("UnityEngineObjectBindings::SetName")]
	private static void SetName(object obj, string name) { }

	[FreeFunction("UnityEngineObjectBindings::ToString")]
	private static string ToString(object obj) { }

	public virtual string ToString() { }

}

