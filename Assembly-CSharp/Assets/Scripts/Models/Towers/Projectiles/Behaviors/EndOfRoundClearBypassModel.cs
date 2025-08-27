namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(EndOfRoundClearBypass), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EndOfRoundClearBypassModel : ProjectileBehaviorModel
{
	public string gameModes; //Field offset: 0x38
	public String[] gameModesList; //Field offset: 0x40

	public EndOfRoundClearBypassModel(string name, string gameModes) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

