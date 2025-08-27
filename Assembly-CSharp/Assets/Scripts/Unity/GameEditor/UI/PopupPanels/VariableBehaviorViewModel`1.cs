namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class VariableBehaviorViewModel : VariableViewModel<T>, IVariableBehaviorViewModel, IVariableViewModel
{
	private BehaviorViewModel _behaviorViewModel; //Field offset: 0x0

	public override Behavior BehaviorValue
	{
		 get { } //Length: 23
		 set { } //Length: 167
	}

	public override BehaviorViewModel BehaviorViewModel
	{
		 get { } //Length: 5
		 set { } //Length: 56
	}

	public override bool IsTypeSwitchable
	{
		 get { } //Length: 210
	}

	public virtual object UntypedValue
	{
		 get { } //Length: 23
		 set { } //Length: 167
	}

	public VariableBehaviorViewModel`1(FieldInfo propertyInfo, object behaviorInstance, bool isNonRemoveable = false) { }

	public override Behavior get_BehaviorValue() { }

	public override BehaviorViewModel get_BehaviorViewModel() { }

	public override bool get_IsTypeSwitchable() { }

	public virtual object get_UntypedValue() { }

	public virtual object GetValue() { }

	public virtual void Initialise() { }

	public void set_BehaviorValue(Behavior value) { }

	public void set_BehaviorViewModel(BehaviorViewModel value) { }

	public virtual void set_UntypedValue(object value) { }

	public virtual void SetValue(object value) { }

}

