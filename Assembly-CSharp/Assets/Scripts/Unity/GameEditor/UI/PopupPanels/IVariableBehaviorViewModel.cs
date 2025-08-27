namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public interface IVariableBehaviorViewModel : IVariableViewModel
{

	public Behavior BehaviorValue
	{
		 get { } //Length: 0
	}

	public BehaviorViewModel BehaviorViewModel
	{
		 get { } //Length: 0
	}

	public bool IsTypeSwitchable
	{
		 get { } //Length: 0
	}

	public Behavior get_BehaviorValue() { }

	public BehaviorViewModel get_BehaviorViewModel() { }

	public bool get_IsTypeSwitchable() { }

}

