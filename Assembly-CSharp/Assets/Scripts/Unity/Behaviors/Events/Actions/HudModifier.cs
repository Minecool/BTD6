namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public abstract class HudModifier : EntityAction
{

	public virtual string Type
	{
		 get { } //Length: 44
	}

	protected HudModifier() { }

	public virtual string get_Type() { }

	public override void ModifyHud(HookCondition condition, object metadata) { }

	public override void OnCleanUp() { }

}

