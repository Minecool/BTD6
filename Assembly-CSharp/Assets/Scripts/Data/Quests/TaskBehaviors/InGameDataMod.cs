namespace Assets.Scripts.Data.Quests.TaskBehaviors;

public abstract class InGameDataMod : TaskBehavior
{

	protected InGameDataMod() { }

	public abstract void ModifyData(InGameData editableInGameData) { }

}

