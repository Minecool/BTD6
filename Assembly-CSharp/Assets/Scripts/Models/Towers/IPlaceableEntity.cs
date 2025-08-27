namespace Assets.Scripts.Models.Towers;

public interface IPlaceableEntity
{

	public bool ContainsAreaType(AreaType areaType) { }

	public bool IsAmphibiousBased() { }

	public bool IsPlaceableInAreaType(AreaType areaType) { }

	public bool IsWaterBased() { }

}

