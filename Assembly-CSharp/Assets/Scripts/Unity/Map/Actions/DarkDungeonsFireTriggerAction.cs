namespace Assets.Scripts.Unity.Map.Actions;

public class DarkDungeonsFireTriggerAction : MapAction
{
	private DarkDungeonsFireTriggerActionModel def; //Field offset: 0x20
	public DarkDungeonsStatue statue; //Field offset: 0x28
	public DarkDungeonsFire fire; //Field offset: 0x30
	public float activationDuration; //Field offset: 0x34

	public virtual MapActionModel Def
	{
		 get { } //Length: 318
	}

	public DarkDungeonsFireTriggerAction() { }

	public virtual MapActionModel get_Def() { }

}

