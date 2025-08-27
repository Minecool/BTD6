namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(RandomArcEmission), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RandomArcEmissionModel : ArcEmissionModel
{
	public float randomAngle; //Field offset: 0x50
	public float startOffset; //Field offset: 0x54

	public RandomArcEmissionModel(string name, int count, float offset, float angle, float randomAngle, float startOffset, EmissionBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

}

