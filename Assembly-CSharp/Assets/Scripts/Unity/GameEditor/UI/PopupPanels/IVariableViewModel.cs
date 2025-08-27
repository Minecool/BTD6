namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public interface IVariableViewModel
{

	public string PrefabName
	{
		 get { } //Length: 0
	}

	public Type Type
	{
		 get { } //Length: 0
	}

	public object UntypedValue
	{
		 get { } //Length: 0
	}

	public string VariableName
	{
		 get { } //Length: 0
	}

	public string get_PrefabName() { }

	public Type get_Type() { }

	public object get_UntypedValue() { }

	public string get_VariableName() { }

	public void SetValue(object value) { }

}

