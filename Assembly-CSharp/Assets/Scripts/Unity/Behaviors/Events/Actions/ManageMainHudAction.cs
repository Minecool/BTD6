namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class ManageMainHudAction : HudModifier
{
	public ToggleModdifier homeButton; //Field offset: 0x18
	public ToggleModdifier autoStartSetting; //Field offset: 0x1C

	public virtual Model Model
	{
		 get { } //Length: 111
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public ManageMainHudAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

