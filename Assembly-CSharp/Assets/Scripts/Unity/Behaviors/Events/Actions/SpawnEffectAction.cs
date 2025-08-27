namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class SpawnEffectAction : EntityAction
{
	[SerializeField]
	public PrefabReference effect; //Field offset: 0x18
	[SerializeField]
	public float lifespan; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 114
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public SpawnEffectAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

