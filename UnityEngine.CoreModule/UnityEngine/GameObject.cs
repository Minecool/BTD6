namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
[UsedByNativeCode]
public sealed class GameObject : object
{

	[Obsolete("GameObject.active is obsolete. Use GameObject.SetActive(), GameObject.activeSelf or GameObject.activeInHierarchy.")]
	public bool active
	{
		[NativeMethod(Name = "IsActive")]
		 get { } //Length: 51
		[NativeMethod(Name = "SetSelfActive")]
		 set { } //Length: 66
	}

	public bool activeInHierarchy
	{
		[NativeMethod(Name = "IsActive")]
		 get { } //Length: 51
	}

	public bool activeSelf
	{
		[NativeMethod(Name = "IsSelfActive")]
		 get { } //Length: 51
	}

	public GameObject gameObject
	{
		 get { } //Length: 6
	}

	public bool isStatic
	{
		[NativeMethod(Name = "GetIsStaticDeprecated")]
		 get { } //Length: 51
		[NativeMethod(Name = "SetIsStaticDeprecated")]
		 set { } //Length: 66
	}

	internal bool isStaticBatchable
	{
		[NativeMethod(Name = "IsStaticBatchable")]
		internal get { } //Length: 51
	}

	public int layer
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Scene scene
	{
		[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = True)]
		 get { } //Length: 68
	}

	public ulong sceneCullingMask
	{
		[FreeFunction(Name = "GameObjectBindings::GetSceneCullingMask", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public string tag
	{
		[FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = True)]
		 get { } //Length: 51
		[FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = True)]
		 set { } //Length: 66
	}

	public Transform transform
	{
		[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public GameObject(string name, Type[] components) { }

	public GameObject() { }

	public GameObject(string name) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component AddComponent(Type componentType) { }

	public T AddComponent() { }

	[FreeFunction(Name = "MonoAddComponent", HasExplicitThis = True)]
	internal Component AddComponentInternal(string className) { }

	[ExcludeFromDocs]
	public void BroadcastMessage(string methodName) { }

	[ExcludeFromDocs]
	public void BroadcastMessage(string methodName, object parameter) { }

	[FreeFunction(Name = "Scripting::BroadcastScriptingMessage", HasExplicitThis = True)]
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	[FreeFunction(Name = "GameObjectBindings::CompareTag", HasExplicitThis = True)]
	public bool CompareTag(string tag) { }

	[FreeFunction("GameObjectBindings::CreatePrimitive")]
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	[FreeFunction(Name = "GameObjectBindings::Find")]
	public static GameObject Find(string name) { }

	[FreeFunction(Name = "GameObjectBindings::FindGameObjectsWithTag", ThrowsException = True)]
	public static GameObject[] FindGameObjectsWithTag(string tag) { }

	[FreeFunction(Name = "GameObjectBindings::FindGameObjectWithTag", ThrowsException = True)]
	public static GameObject FindGameObjectWithTag(string tag) { }

	public static GameObject FindWithTag(string tag) { }

	[NativeMethod(Name = "IsActive")]
	public bool get_active() { }

	[NativeMethod(Name = "IsActive")]
	public bool get_activeInHierarchy() { }

	[NativeMethod(Name = "IsSelfActive")]
	public bool get_activeSelf() { }

	public GameObject get_gameObject() { }

	[NativeMethod(Name = "GetIsStaticDeprecated")]
	public bool get_isStatic() { }

	[NativeMethod(Name = "IsStaticBatchable")]
	internal bool get_isStaticBatchable() { }

	public int get_layer() { }

	[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = True)]
	public Scene get_scene() { }

	private void get_scene_Injected(out Scene ret) { }

	[FreeFunction(Name = "GameObjectBindings::GetSceneCullingMask", HasExplicitThis = True)]
	public ulong get_sceneCullingMask() { }

	[FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = True)]
	public string get_tag() { }

	[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
	public Transform get_transform() { }

	public T GetComponent() { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponent(Type type) { }

	public Component GetComponent(string type) { }

	public Component GetComponentAtIndex(int index) { }

	public T GetComponentAtIndex(int index) { }

	[FreeFunction(Name = "Scripting::GetScriptingWrapperOfComponentOfGameObject", HasExplicitThis = True)]
	internal Component GetComponentByName(string type) { }

	[FreeFunction(Name = "Scripting::GetScriptingWrapperOfComponentOfGameObjectWithCase", HasExplicitThis = True)]
	internal Component GetComponentByNameWithCase(string type, bool caseSensitive) { }

	public int GetComponentCount() { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	[NativeWritableSelf]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[ExcludeFromDocs]
	public T GetComponentInChildren() { }

	public T GetComponentInChildren(bool includeInactive) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type type) { }

	public int GetComponentIndex(Component component) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type type) { }

	[ExcludeFromDocs]
	public T GetComponentInParent() { }

	public T GetComponentInParent(bool includeInactive) { }

	public void GetComponents(List<T> results) { }

	public void GetComponents(Type type, List<Component> results) { }

	public T[] GetComponents() { }

	public Component[] GetComponents(Type type) { }

	public void GetComponentsInChildren(List<T> results) { }

	public T[] GetComponentsInChildren(bool includeInactive) { }

	public Component[] GetComponentsInChildren(Type type, bool includeInactive) { }

	public void GetComponentsInChildren(bool includeInactive, List<T> results) { }

	public T[] GetComponentsInChildren() { }

	[ExcludeFromDocs]
	public Component[] GetComponentsInChildren(Type type) { }

	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	[ExcludeFromDocs]
	public Component[] GetComponentsInParent(Type type) { }

	public T[] GetComponentsInParent(bool includeInactive) { }

	public T[] GetComponentsInParent() { }

	public Component[] GetComponentsInParent(Type type, bool includeInactive) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = True, ThrowsException = True)]
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	[FreeFunction(Name = "GameObjectBindings::GetSceneByInstanceID")]
	public static Scene GetScene(int instanceID) { }

	private static void GetScene_Injected(int instanceID, out Scene ret) { }

	public static void InstantiateGameObjects(int sourceInstanceID, int count, NativeArray<Int32> newInstanceIDs, NativeArray<Int32> newTransformInstanceIDs, Scene destinationScene = null) { }

	[FreeFunction("GameObjectBindings::InstantiateGameObjectsByInstanceID")]
	private static void InstantiateGameObjects(int sourceInstanceID, IntPtr newInstanceIDs, IntPtr newTransformInstanceIDs, int count, Scene destinationScene) { }

	private static void InstantiateGameObjects_Injected(int sourceInstanceID, IntPtr newInstanceIDs, IntPtr newTransformInstanceIDs, int count, ref Scene destinationScene) { }

	[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = True)]
	private Component Internal_AddComponentWithType(Type componentType) { }

	[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[NativeName("QueryComponentAtIndex<Unity::Component>")]
	internal Component QueryComponentAtIndex(int index) { }

	[ExcludeFromDocs]
	public void SendMessage(string methodName) { }

	public void SendMessage(string methodName, SendMessageOptions options) { }

	[ExcludeFromDocs]
	public void SendMessage(string methodName, object value) { }

	[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = True)]
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocs]
	public void SendMessageUpwards(string methodName) { }

	[ExcludeFromDocs]
	public void SendMessageUpwards(string methodName, object value) { }

	[FreeFunction(Name = "Scripting::SendScriptingMessageUpwards", HasExplicitThis = True)]
	public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }

	public void SendMessageUpwards(string methodName, SendMessageOptions options) { }

	[NativeMethod(Name = "SetSelfActive")]
	public void set_active(bool value) { }

	[NativeMethod(Name = "SetIsStaticDeprecated")]
	public void set_isStatic(bool value) { }

	public void set_layer(int value) { }

	[FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = True)]
	public void set_tag(string value) { }

	[NativeMethod(Name = "SetSelfActive")]
	public void SetActive(bool value) { }

	[NativeMethod(Name = "SetActiveRecursivelyDeprecated")]
	[Obsolete("gameObject.SetActiveRecursively() is obsolete. Use GameObject.SetActive(), which is now inherited by children.")]
	public void SetActiveRecursively(bool state) { }

	public static void SetGameObjectsActive(NativeArray<Int32> instanceIDs, bool active) { }

	public static void SetGameObjectsActive(ReadOnlySpan<Int32> instanceIDs, bool active) { }

	[FreeFunction(Name = "GameObjectBindings::SetGameObjectsActiveByInstanceID")]
	private static void SetGameObjectsActive(IntPtr instanceIds, int instanceCount, bool active) { }

	public bool TryGetComponent(out T component) { }

	public bool TryGetComponent(Type type, out Component component) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	[NativeWritableSelf]
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	internal Component TryGetComponentInternal(Type type) { }

}

