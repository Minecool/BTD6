namespace Assets.Scripts.Data.Behaviors;

[UIComponent("Default")]
public abstract class Behavior : ScriptableObject, IUIBehavior
{
	[JsonIgnore]
	[UIVariableHidden]
	public ScriptableObject parentScriptable; //Field offset: 0x18
	[UIVariableHidden]
	public string id; //Field offset: 0x20

	[JsonIgnore]
	public abstract Model Model
	{
		 get { } //Length: 0
	}

	protected Behavior() { }

	public abstract Model get_Model() { }

}

