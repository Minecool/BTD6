namespace Assets.Scripts.Unity.Map.Gizmos;

public class DarkDungeonsStatue : MapGizmoBehavior
{
	private DarkDungeonsStatueModel def; //Field offset: 0x28
	public int cost; //Field offset: 0x30
	[SerializeReference]
	public CreateTowerAction createStatueTower; //Field offset: 0x38
	public DarkDungeonsStatueActiveTrigger statueActiveTrigger; //Field offset: 0x40

	public virtual MapGizmoBehaviorModel Def
	{
		 get { } //Length: 349
	}

	public DarkDungeonsStatue() { }

	public virtual MapGizmoBehaviorModel get_Def() { }

}

