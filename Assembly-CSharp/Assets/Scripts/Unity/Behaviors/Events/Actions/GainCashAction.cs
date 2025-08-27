namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class GainCashAction : EntityAction
{
	public float amount; //Field offset: 0x18
	public bool showFloatingText; //Field offset: 0x1C
	public PrefabReference textAssetId; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 134
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public GainCashAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

