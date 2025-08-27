namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class PathNodeSettings
{
	public const float DEFAULT_SCALE_VALUE = 1; //Field offset: 0x0
	public NodeToggledStates moabInvulNodeState; //Field offset: 0x10
	public NodeToggledStates bloonInvulNodeState; //Field offset: 0x14
	public NodeToggledStates scaledMoabNodeState; //Field offset: 0x18
	public NodeToggledStates scaledBloonNodeState; //Field offset: 0x1C
	public NodeToggledStates scaledSpeedNodeState; //Field offset: 0x20
	public bool invulMoabValue; //Field offset: 0x24
	public bool invulBloonValue; //Field offset: 0x25
	public float scaleMoabValue; //Field offset: 0x28
	public float scaleBloonValue; //Field offset: 0x2C
	public float scaleSpeedValue; //Field offset: 0x30

	public PathNodeSettings() { }

	private float ConvertInputToNodeScaleValue(float valueToConvert, bool isRightButtonPressed, float minValueClamp, float maxValueClamp) { }

	public void CopyNodeSettings(PathSplineNode precedingNode) { }

	private NodeToggledStates GetKeyFrameNodeToggledState(float newNodeScaleValue, float precedingNodesScaleValueState) { }

	private NodeToggledStates GetZoneNodeToggledState(PathSettingType setting, PathSettingType enabledType, bool isEnabled) { }

	public bool IsPathSettingTypeScaling(PathSettingType setting) { }

	public void LoadData(int index, PathNode saveData = null) { }

	public bool PropagateSetting(PathSettingType settingType, bool isEnabled, bool backPropagate = false) { }

	public void SetData(PathSettingType settingType, bool isEnabled, PathSplineNode precedingNode) { }

	private bool TryPropagateScaleSetting(bool isEnabled, ref NodeToggledStates stateToToggle, ref float value, float minValueClamp, float maxValueClamp) { }

	private bool TryPropagateValueSetting(NodeToggledStates propagationFlagToStopAt, bool isEnabled, ref NodeToggledStates stateToToggle, ref bool value) { }

}

