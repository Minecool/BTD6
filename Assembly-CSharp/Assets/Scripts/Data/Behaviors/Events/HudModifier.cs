namespace Assets.Scripts.Data.Behaviors.Events;

public abstract class HudModifier : EntityAction
{

	protected HudModifier() { }

	public override void ModifyHud(HookCondition condition, object metadata) { }

	public override void OnCleanUp() { }

}

