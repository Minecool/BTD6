namespace Assets.Scripts.Data.Behaviors.Emissions;

public abstract class Emission : EntityBehavior<EmissionModel>
{
	public EmissionBehavior[] emissionBehaviors; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected Emission() { }

	public virtual Model get_Model() { }

}

