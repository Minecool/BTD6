namespace UnityEngine;

[NativeClass("Unity::Component")]
[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
[RequiredByNativeCode]
public class Component : object
{

	public GameObject gameObject
	{
		[FreeFunction("GetGameObject", HasExplicitThis = True)]
		 get { } //Length: 144
	}

	public string tag
	{
		 get { } //Length: 159
		 set { } //Length: 175
	}

	public Transform transform
	{
		[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
		 get { } //Length: 144
	}

	public Component() { }

	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	[ExcludeFromDocs]
	public void BroadcastMessage(string methodName) { }

	[ExcludeFromDocs]
	public void BroadcastMessage(string methodName, object parameter) { }

	[FreeFunction("BroadcastMessage", HasExplicitThis = True)]
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	private static void BroadcastMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object parameter, SendMessageOptions options) { }

	public bool CompareTag(TagHandle tag) { }

	public bool CompareTag(string tag) { }

	[FreeFunction("GetGameObject", HasExplicitThis = True)]
	public GameObject get_gameObject() { }

	private static IntPtr get_gameObject_Injected(IntPtr _unity_self) { }

	public string get_tag() { }

	[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
	public Transform get_transform() { }

	private static IntPtr get_transform_Injected(IntPtr _unity_self) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponent(Type type) { }

	[FreeFunction(HasExplicitThis = True)]
	public Component GetComponent(string type) { }

	public T GetComponent() { }

	private static IntPtr GetComponent_Injected(IntPtr _unity_self, ref ManagedSpanWrapper type) { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	private static void GetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type t) { }

	[ExcludeFromDocs]
	public T GetComponentInChildren() { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	public T GetComponentInChildren(bool includeInactive) { }

	public int GetComponentIndex() { }

	private static int GetComponentIndex_Injected(IntPtr _unity_self) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type t) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type t, bool includeInactive) { }

	public T GetComponentInParent() { }

	public T GetComponentInParent(bool includeInactive) { }

	public T[] GetComponents() { }

	public void GetComponents(Type type, List<Component> results) { }

	public Component[] GetComponents(Type type) { }

	public void GetComponents(List<T> results) { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	private static void GetComponentsForListInternal_Injected(IntPtr _unity_self, Type searchType, object resultList) { }

	public Component[] GetComponentsInChildren(Type t, bool includeInactive) { }

	[ExcludeFromDocs]
	public Component[] GetComponentsInChildren(Type t) { }

	public T[] GetComponentsInChildren(bool includeInactive) { }

	public void GetComponentsInChildren(bool includeInactive, List<T> result) { }

	public T[] GetComponentsInChildren() { }

	public void GetComponentsInChildren(List<T> results) { }

	public T[] GetComponentsInParent() { }

	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	public Component[] GetComponentsInParent(Type t, bool includeInactive) { }

	[ExcludeFromDocs]
	public Component[] GetComponentsInParent(Type t) { }

	public T[] GetComponentsInParent(bool includeInactive) { }

	public void SendMessage(string methodName, SendMessageOptions options) { }

	[FreeFunction("SendMessage", HasExplicitThis = True)]
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	public void SendMessage(string methodName) { }

	public void SendMessage(string methodName, object value) { }

	private static void SendMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value, SendMessageOptions options) { }

	public void SendMessageUpwards(string methodName, SendMessageOptions options) { }

	[ExcludeFromDocs]
	public void SendMessageUpwards(string methodName) { }

	[ExcludeFromDocs]
	public void SendMessageUpwards(string methodName, object value) { }

	[FreeFunction(HasExplicitThis = True)]
	public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }

	private static void SendMessageUpwards_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value, SendMessageOptions options) { }

	public void set_tag(string value) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public bool TryGetComponent(Type type, out Component component) { }

	public bool TryGetComponent(out T component) { }

}

