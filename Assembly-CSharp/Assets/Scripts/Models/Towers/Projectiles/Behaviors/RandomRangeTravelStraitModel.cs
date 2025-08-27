namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(RandomRangeTravelStrait), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RandomRangeTravelStraitModel : ProjectileBehaviorModel
{
	public float minRange; //Field offset: 0x38
	public float maxRange; //Field offset: 0x3C
	public float speed; //Field offset: 0x40
	public float speedFrames; //Field offset: 0x44

	public RandomRangeTravelStraitModel(string name, float speed = 4, float minRange = 4, float maxRange = 4) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

