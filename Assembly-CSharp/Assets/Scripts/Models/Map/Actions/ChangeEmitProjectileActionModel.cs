namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(ChangeEmitProjectileAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ChangeEmitProjectileActionModel : MapActionModel
{
	public string mapEventName; //Field offset: 0x38
	public ProjectileModel newProjectileModel; //Field offset: 0x40

	public ChangeEmitProjectileActionModel(string name, string mapEventName, ProjectileModel newProjectileModel) { }

}

