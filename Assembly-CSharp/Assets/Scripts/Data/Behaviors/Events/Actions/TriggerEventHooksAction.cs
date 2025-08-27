namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class TriggerEventHooksAction : HudModifier
{
	public String[] eventHookIds; //Field offset: 0x28
	public ToggleModdifier toggleEventHooks; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 112
	}

	public TriggerEventHooksAction() { }

	public virtual Model get_Model() { }

}

