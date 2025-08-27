namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "RemoveMutatorOnUpgrade", menuName = "BTD6/Behaviors/Towers/RemoveMutatorOnUpgrade")]
public class RemoveMutatorOnUpgrade : TowerBehavior
{
	public string mutatorId; //Field offset: 0x30
	public int firstPath; //Field offset: 0x38
	public int secondPath; //Field offset: 0x3C
	public int thirdPath; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 149
	}

	public RemoveMutatorOnUpgrade() { }

	public virtual TowerBehaviorModel get_Def() { }

}

