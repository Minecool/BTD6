namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(Turbo), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TurboModel : AbilityBehaviorModel
{
	public float multiplier; //Field offset: 0x30
	public AssetPathModel projectileDisplay; //Field offset: 0x38
	[SerializeField]
	private float lifespan; //Field offset: 0x40
	public int lifespanFrames; //Field offset: 0x44
	public int extraDamage; //Field offset: 0x48
	public float projectileRadiusScaleBonus; //Field offset: 0x4C
	public bool dontRemoveMutatorOnDestroy; //Field offset: 0x50

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public TurboModel(string name, float lifespan, float multiplier, AssetPathModel projectileDisplay, int extraDamage, float projectileRadiusScaleBonus, bool dontRemoveMutatorOnDestroy) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

