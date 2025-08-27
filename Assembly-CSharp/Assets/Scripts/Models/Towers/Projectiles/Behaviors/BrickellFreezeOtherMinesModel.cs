namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(BrickellFreezeOtherMines), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BrickellFreezeOtherMinesModel : ProjectileBehaviorModel
{
	[SerializeField]
	private float freezeDuration; //Field offset: 0x38
	public int freezeDurationFrames; //Field offset: 0x3C

	public float FreezeDuration
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public BrickellFreezeOtherMinesModel(string name, float freezeDuration) { }

	public virtual Model Clone() { }

	public float get_FreezeDuration() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_FreezeDuration(float value) { }

}

