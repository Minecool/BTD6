namespace Assets.Scripts.Unity.Map.Actions;

public class SetRegenRemovableActiveAction : MapAction
{
	private SetRegenRemovableActiveActionModel def; //Field offset: 0x20
	public RegenRemovable regenRemovable; //Field offset: 0x28
	public bool isActive; //Field offset: 0x30

	public virtual MapActionModel Def
	{
		 get { } //Length: 196
	}

	public SetRegenRemovableActiveAction() { }

	public virtual MapActionModel get_Def() { }

}

