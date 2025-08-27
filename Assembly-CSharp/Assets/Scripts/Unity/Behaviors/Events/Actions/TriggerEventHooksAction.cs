namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class TriggerEventHooksAction : HudModifier
{
	public String[] eventHookIds; //Field offset: 0x18
	public ToggleModdifier toggleEventHooks; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 112
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public TriggerEventHooksAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

	public virtual void ModifyHud(HookCondition condition, object metadata) { }

}

