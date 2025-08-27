namespace Assets.Scripts.Unity.Cascade;

public class ObjectReference : GenericObjectReference
{
	public ObjectReference<T> parent; //Field offset: 0x0
	private T val; //Field offset: 0x0
	[CompilerGenerated]
	private Action<Object> OnSet; //Field offset: 0x0

	public override event Action<Object> OnSet
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public override object Object
	{
		 get { } //Length: 5
		 set { } //Length: 321
	}

	public ObjectReference<T> Parent
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public override object ParentedObject
	{
		 get { } //Length: 20
	}

	public override GenericObjectReference ParentObject
	{
		 get { } //Length: 5
		 set { } //Length: 138
	}

	public T Val
	{
		 get { } //Length: 175
	}

	public ObjectReference`1() { }

	[CompilerGenerated]
	public override void add_OnSet(Action<Object> value) { }

	public override void ForceUpdate() { }

	public override object get_Object() { }

	public ObjectReference<T> get_Parent() { }

	public override object get_ParentedObject() { }

	public override GenericObjectReference get_ParentObject() { }

	public T get_Val() { }

	public static T op_Implicit(ObjectReference<T> o) { }

	[CompilerGenerated]
	public override void remove_OnSet(Action<Object> value) { }

	public override void set_Object(object value) { }

	public void set_Parent(ObjectReference<T> value) { }

	public override void set_ParentObject(GenericObjectReference value) { }

}

