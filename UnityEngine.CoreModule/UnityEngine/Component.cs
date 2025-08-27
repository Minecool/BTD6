namespace UnityEngine;

[NativeClass("Unity::Component")]
[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
[RequiredByNativeCode]
public class Component : object
{

	public GameObject gameObject
	{
		[FreeFunction("GetGameObject", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public string tag
	{
		 get { } //Length: 100
		 set { } //Length: 115
	}

	public Transform transform
	{
		[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
		 get { } //Length: 51
	}

	public Component() { }

	[ExcludeFromDocs]
	public void BroadcastMessage(string methodName) { }

	[ExcludeFromDocs]
	public void BroadcastMessage(string methodName, object parameter) { }

	[FreeFunction("BroadcastMessage", HasExplicitThis = True)]
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	public bool CompareTag(string tag) { }

	[FreeFunction("GetGameObject", HasExplicitThis = True)]
	public GameObject get_gameObject() { }

	public string get_tag() { }

	[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
	public Transform get_transform() { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponent(Type type) { }

	public T GetComponent() { }

	[FreeFunction(HasExplicitThis = True)]
	public Component GetComponent(string type) { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type t) { }

	public T GetComponentInChildren(bool includeInactive) { }

	[ExcludeFromDocs]
	public T GetComponentInChildren() { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	public int GetComponentIndex() { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type t, bool includeInactive) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type t) { }

	public T GetComponentInParent(bool includeInactive) { }

	public T GetComponentInParent() { }

	public void GetComponents(List<T> results) { }

	public T[] GetComponents() { }

	public void GetComponents(Type type, List<Component> results) { }

	public Component[] GetComponents(Type type) { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	public Component[] GetComponentsInChildren(Type t, bool includeInactive) { }

	[ExcludeFromDocs]
	public Component[] GetComponentsInChildren(Type t) { }

	public void GetComponentsInChildren(List<T> results) { }

	public T[] GetComponentsInChildren(bool includeInactive) { }

	public T[] GetComponentsInChildren() { }

	public void GetComponentsInChildren(bool includeInactive, List<T> result) { }

	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	public T[] GetComponentsInParent() { }

	public T[] GetComponentsInParent(bool includeInactive) { }

	public Component[] GetComponentsInParent(Type t, bool includeInactive) { }

	[ExcludeFromDocs]
	public Component[] GetComponentsInParent(Type t) { }

	public void SendMessage(string methodName, object value) { }

	public void SendMessage(string methodName) { }

	[FreeFunction("SendMessage", HasExplicitThis = True)]
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	public void SendMessage(string methodName, SendMessageOptions options) { }

	[FreeFunction(HasExplicitThis = True)]
	public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocs]
	public void SendMessageUpwards(string methodName) { }

	public void SendMessageUpwards(string methodName, SendMessageOptions options) { }

	[ExcludeFromDocs]
	public void SendMessageUpwards(string methodName, object value) { }

	public void set_tag(string value) { }

	public bool TryGetComponent(out T component) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public bool TryGetComponent(Type type, out Component component) { }

}

