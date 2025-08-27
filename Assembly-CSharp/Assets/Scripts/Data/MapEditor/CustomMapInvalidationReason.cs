namespace Assets.Scripts.Data.MapEditor;

[Flags]
public enum CustomMapInvalidationReason
{
	BaseMapTextureIdUnassigned = 0,
	TowerDataInvalid = 1,
	PowerDataInvalid = 2,
	PathDataNull = 4,
	PathDataEmpty = 8,
	PathDataExceedsMaxCount = 16,
	PathDataInvalid = 32,
	AreaDataNull = 64,
	AreaDataExceedsMaxLayers = 128,
	AreaDataInvalid = 256,
	PropDataNull = 512,
	StampDataNull = 1024,
	PlaceablesExceedMaxCount = 2048,
	StampDataExceedsMaxLayers = 4096,
	PathPatternSettingsInvalid = 8192,
	PathLengthInvalid = 16384,
	InvalidPath = 56,
}

