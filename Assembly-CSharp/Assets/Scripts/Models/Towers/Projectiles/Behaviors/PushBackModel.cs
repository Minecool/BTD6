namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(PushBack), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PushBackModel : ProjectileBehaviorModel
{
	public float pushAmount; //Field offset: 0x38
	public string tag; //Field offset: 0x40
	public float multiplierMOAB; //Field offset: 0x48
	public float multiplierBFB; //Field offset: 0x4C
	public float multiplierDDT; //Field offset: 0x50
	public float multiplierZOMG; //Field offset: 0x54
	public bool onlyIfDamaged; //Field offset: 0x58

	public PushBackModel(string name, float pushAmount, string tag, float multiplierMOAB, float multiplierBFB, float multiplierDDT, float multiplierZOMG, bool onlyIfDamaged) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

