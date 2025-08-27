namespace Assets.Scripts.Unity.Cascade;

public interface GenericObjectReference
{

	public event Action<Object> OnSet
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public object Object
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public object ParentedObject
	{
		 get { } //Length: 0
	}

	public GenericObjectReference ParentObject
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnSet(Action<Object> value) { }

	public void ForceUpdate() { }

	public object get_Object() { }

	public object get_ParentedObject() { }

	public GenericObjectReference get_ParentObject() { }

	[CompilerGenerated]
	public void remove_OnSet(Action<Object> value) { }

	public void set_Object(object value) { }

	public void set_ParentObject(GenericObjectReference value) { }

}

