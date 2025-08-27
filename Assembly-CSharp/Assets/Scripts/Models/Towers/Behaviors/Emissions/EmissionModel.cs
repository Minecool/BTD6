namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

public abstract class EmissionModel : Model
{
	public EmissionBehaviorModel[] behaviors; //Field offset: 0x30

	protected EmissionModel(string name, EmissionBehaviorModel[] behaviors) { }

}

