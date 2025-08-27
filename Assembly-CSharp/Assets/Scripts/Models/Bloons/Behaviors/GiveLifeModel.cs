namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(GiveLife), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GiveLifeModel : BloonBehaviorModel
{
	public float lifeToGive; //Field offset: 0x30

	public GiveLifeModel() { }

	public GiveLifeModel(string name, float lifeToGive) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

