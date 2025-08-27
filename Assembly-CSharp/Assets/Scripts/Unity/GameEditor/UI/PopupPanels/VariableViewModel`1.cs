namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class VariableViewModel : VariableBaseViewModel
{
	private T _value; //Field offset: 0x0
	protected readonly object _behaviorInstance; //Field offset: 0x0
	private Nullable<Boolean> _isHidden; //Field offset: 0x0

	public bool IsHidden
	{
		 get { } //Length: 238
	}

	public virtual object UntypedValue
	{
		 get { } //Length: 43
		 set { } //Length: 340
	}

	public T Value
	{
		 get { } //Length: 5
		 set { } //Length: 123
	}

	public VariableViewModel`1(FieldInfo propertyInfo, object behaviorInstance, bool isNonRemoveable = false) { }

	public bool get_IsHidden() { }

	public virtual object get_UntypedValue() { }

	public T get_Value() { }

	public virtual object GetValue() { }

	public virtual void Initialise() { }

	public virtual void set_UntypedValue(object value) { }

	public void set_Value(T value) { }

	public virtual void SetValue(object value) { }

}

