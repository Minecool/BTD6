namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class SpawnTowerAction : EntityAction
{
	[SerializeField]
	public string towerId; //Field offset: 0x28
	[SerializeField]
	public Int32[] tiers; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 113
	}

	public SpawnTowerAction() { }

	public virtual Model get_Model() { }

}

