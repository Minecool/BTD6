namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class SpawnTowerAction : EntityAction
{
	[SerializeField]
	public string towerId; //Field offset: 0x18
	[SerializeField]
	public Int32[] tiers; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 113
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public SpawnTowerAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

