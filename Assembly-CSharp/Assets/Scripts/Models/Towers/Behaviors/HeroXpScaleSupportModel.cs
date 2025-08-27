namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(HeroXpScaleSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HeroXpScaleSupportModel : SupportModel
{
	public bool isUnique; //Field offset: 0x60
	public float heroXpScale; //Field offset: 0x64

	public HeroXpScaleSupportModel(string name, bool isUnique, float heroXpScale, TowerFilterModel[] filters, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

