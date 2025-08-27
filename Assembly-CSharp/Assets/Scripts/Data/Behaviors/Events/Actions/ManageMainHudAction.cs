namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class ManageMainHudAction : HudModifier
{
	public ToggleModdifier homeButton; //Field offset: 0x28
	public ToggleModdifier autoStartSetting; //Field offset: 0x2C

	public virtual Model Model
	{
		 get { } //Length: 111
	}

	public ManageMainHudAction() { }

	public virtual Model get_Model() { }

}

