namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[UsedByNativeCode]
public class Animator : Behaviour
{

	internal bool allowConstantClipSamplingOptimization
	{
		internal get { } //Length: 51
		internal set { } //Length: 66
	}

	public Vector3 angularVelocity
	{
		 get { } //Length: 77
	}

	[Obsolete("Animator.animatePhysics has been deprecated. Use Animator.updateMode instead.")]
	public bool animatePhysics
	{
		 get { } //Length: 57
		 set { } //Length: 75
	}

	public bool applyRootMotion
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Avatar avatar
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Transform avatarRoot
	{
		 get { } //Length: 51
	}

	public Vector3 bodyPosition
	{
		 get { } //Length: 117
		 set { } //Length: 92
	}

	internal Vector3 bodyPositionInternal
	{
		[NativeMethod("GetBodyPosition")]
		internal get { } //Length: 77
		[NativeMethod("SetBodyPosition")]
		internal set { } //Length: 66
	}

	public Quaternion bodyRotation
	{
		 get { } //Length: 103
		 set { } //Length: 83
	}

	internal Quaternion bodyRotationInternal
	{
		[NativeMethod("GetBodyRotation")]
		internal get { } //Length: 75
		[NativeMethod("SetBodyRotation")]
		internal set { } //Length: 66
	}

	public AnimatorCullingMode cullingMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Vector3 deltaPosition
	{
		 get { } //Length: 77
	}

	public Quaternion deltaRotation
	{
		 get { } //Length: 75
	}

	public float feetPivotActive
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool fireEvents
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float gravityWeight
	{
		 get { } //Length: 51
	}

	public bool hasBoundPlayables
	{
		[NativeMethod("HasBoundPlayables")]
		 get { } //Length: 51
	}

	public bool hasRootMotion
	{
		[NativeMethod("HasRootMotion")]
		 get { } //Length: 51
	}

	public bool hasTransformHierarchy
	{
		 get { } //Length: 51
	}

	public float humanScale
	{
		 get { } //Length: 51
	}

	public bool isHuman
	{
		[NativeMethod("IsHuman")]
		 get { } //Length: 51
	}

	public bool isInitialized
	{
		[NativeMethod("IsInitialized")]
		 get { } //Length: 51
	}

	public bool isMatchingTarget
	{
		[NativeMethod("IsMatchingTarget")]
		 get { } //Length: 51
	}

	public bool isOptimizable
	{
		[NativeMethod("IsOptimizable")]
		 get { } //Length: 51
	}

	internal bool isRootPositionOrRotationControlledByCurves
	{
		[NativeMethod("IsRootTranslationOrRotationControllerByCurves")]
		internal get { } //Length: 51
	}

	[Obsolete("keepAnimatorControllerStateOnDisable is deprecated, use keepAnimatorStateOnDisable instead. (UnityUpgradable) -> keepAnimatorStateOnDisable", False)]
	public bool keepAnimatorControllerStateOnDisable
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool keepAnimatorStateOnDisable
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int layerCount
	{
		 get { } //Length: 51
	}

	public bool layersAffectMassCenter
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float leftFeetBottomHeight
	{
		 get { } //Length: 51
	}

	[Obsolete("Animator.linearVelocityBlending is no longer used and has been deprecated.")]
	public bool linearVelocityBlending
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool logWarnings
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int parameterCount
	{
		 get { } //Length: 51
	}

	public AnimatorControllerParameter[] parameters
	{
		[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public Vector3 pivotPosition
	{
		 get { } //Length: 77
	}

	public float pivotWeight
	{
		 get { } //Length: 51
	}

	public PlayableGraph playableGraph
	{
		 get { } //Length: 90
	}

	public float playbackTime
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public AnimatorRecorderMode recorderMode
	{
		 get { } //Length: 51
	}

	public float recorderStartTime
	{
		 get { } //Length: 51
		 set { } //Length: 3
	}

	public float recorderStopTime
	{
		 get { } //Length: 51
		 set { } //Length: 3
	}

	public float rightFeetBottomHeight
	{
		 get { } //Length: 51
	}

	public Vector3 rootPosition
	{
		[NativeMethod("GetAvatarPosition")]
		 get { } //Length: 77
		[NativeMethod("SetAvatarPosition")]
		 set { } //Length: 66
	}

	public Quaternion rootRotation
	{
		[NativeMethod("GetAvatarRotation")]
		 get { } //Length: 75
		[NativeMethod("SetAvatarRotation")]
		 set { } //Length: 66
	}

	public RuntimeAnimatorController runtimeAnimatorController
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float speed
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool stabilizeFeet
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeConditional("UNITY_EDITOR")]
	internal bool supportsOnAnimatorMove
	{
		[NativeMethod("SupportsOnAnimatorMove")]
		internal get { } //Length: 51
	}

	public Vector3 targetPosition
	{
		 get { } //Length: 77
	}

	public Quaternion targetRotation
	{
		 get { } //Length: 75
	}

	public AnimatorUpdateMode updateMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Vector3 velocity
	{
		 get { } //Length: 77
	}

	public bool writeDefaultValuesOnDisable
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Animator() { }

	public void ApplyBuiltinRootMotion() { }

	private void CheckIfInIKPass() { }

	internal void ClearInternalControllerPlayable() { }

	private static T[] ConvertStateMachineBehaviour(ScriptableObject[] rawObjects) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	[FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = True)]
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration) { }

	[FreeFunction(Name = "AnimatorBindings::CrossFadeInFixedTime", HasExplicitThis = True)]
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) { }

	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) { }

	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) { }

	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) { }

	[NativeConditional("UNITY_EDITOR")]
	internal void EvaluateController() { }

	private void EvaluateController(float deltaTime) { }

	[Obsolete("ForceStateNormalizedTime is deprecated. Please use Play or CrossFade instead.")]
	public void ForceStateNormalizedTime(float normalizedTime) { }

	internal bool get_allowConstantClipSamplingOptimization() { }

	public Vector3 get_angularVelocity() { }

	private void get_angularVelocity_Injected(out Vector3 ret) { }

	public bool get_animatePhysics() { }

	public bool get_applyRootMotion() { }

	public Avatar get_avatar() { }

	public Transform get_avatarRoot() { }

	public Vector3 get_bodyPosition() { }

	[NativeMethod("GetBodyPosition")]
	internal Vector3 get_bodyPositionInternal() { }

	private void get_bodyPositionInternal_Injected(out Vector3 ret) { }

	public Quaternion get_bodyRotation() { }

	[NativeMethod("GetBodyRotation")]
	internal Quaternion get_bodyRotationInternal() { }

	private void get_bodyRotationInternal_Injected(out Quaternion ret) { }

	public AnimatorCullingMode get_cullingMode() { }

	public Vector3 get_deltaPosition() { }

	private void get_deltaPosition_Injected(out Vector3 ret) { }

	public Quaternion get_deltaRotation() { }

	private void get_deltaRotation_Injected(out Quaternion ret) { }

	public float get_feetPivotActive() { }

	public bool get_fireEvents() { }

	public float get_gravityWeight() { }

	[NativeMethod("HasBoundPlayables")]
	public bool get_hasBoundPlayables() { }

	[NativeMethod("HasRootMotion")]
	public bool get_hasRootMotion() { }

	public bool get_hasTransformHierarchy() { }

	public float get_humanScale() { }

	[NativeMethod("IsHuman")]
	public bool get_isHuman() { }

	[NativeMethod("IsInitialized")]
	public bool get_isInitialized() { }

	[NativeMethod("IsMatchingTarget")]
	public bool get_isMatchingTarget() { }

	[NativeMethod("IsOptimizable")]
	public bool get_isOptimizable() { }

	[NativeMethod("IsRootTranslationOrRotationControllerByCurves")]
	internal bool get_isRootPositionOrRotationControlledByCurves() { }

	public bool get_keepAnimatorControllerStateOnDisable() { }

	public bool get_keepAnimatorStateOnDisable() { }

	public int get_layerCount() { }

	public bool get_layersAffectMassCenter() { }

	public float get_leftFeetBottomHeight() { }

	public bool get_linearVelocityBlending() { }

	public bool get_logWarnings() { }

	public int get_parameterCount() { }

	[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
	public AnimatorControllerParameter[] get_parameters() { }

	public Vector3 get_pivotPosition() { }

	private void get_pivotPosition_Injected(out Vector3 ret) { }

	public float get_pivotWeight() { }

	public PlayableGraph get_playableGraph() { }

	public float get_playbackTime() { }

	public AnimatorRecorderMode get_recorderMode() { }

	public float get_recorderStartTime() { }

	public float get_recorderStopTime() { }

	public float get_rightFeetBottomHeight() { }

	[NativeMethod("GetAvatarPosition")]
	public Vector3 get_rootPosition() { }

	private void get_rootPosition_Injected(out Vector3 ret) { }

	[NativeMethod("GetAvatarRotation")]
	public Quaternion get_rootRotation() { }

	private void get_rootRotation_Injected(out Quaternion ret) { }

	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	public float get_speed() { }

	public bool get_stabilizeFeet() { }

	[NativeMethod("SupportsOnAnimatorMove")]
	internal bool get_supportsOnAnimatorMove() { }

	public Vector3 get_targetPosition() { }

	private void get_targetPosition_Injected(out Vector3 ret) { }

	public Quaternion get_targetRotation() { }

	private void get_targetRotation_Injected(out Quaternion ret) { }

	public AnimatorUpdateMode get_updateMode() { }

	public Vector3 get_velocity() { }

	private void get_velocity_Injected(out Vector3 ret) { }

	public bool get_writeDefaultValuesOnDisable() { }

	internal int GetAnimatorClipInfoCount(int layerIndex, bool current) { }

	[FreeFunction(Name = "AnimatorBindings::GetAnimatorClipInfoInternal", HasExplicitThis = True)]
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	[NativeConditional("UNITY_EDITOR")]
	private string GetAnimatorStateName(int layerIndex, bool current) { }

	private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) { }

	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	public T GetBehaviour() { }

	private ScriptableObject GetBehaviour(Type type) { }

	public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) { }

	public T[] GetBehaviours() { }

	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	[NativeMethod("GetBoneTransform")]
	internal Transform GetBoneTransformInternal(int humanBoneId) { }

	public bool GetBool(int id) { }

	public bool GetBool(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = True)]
	private bool GetBoolID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::GetBoolString", HasExplicitThis = True)]
	private bool GetBoolString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetCurrentAnimatorClipInfo", HasExplicitThis = True)]
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	public int GetCurrentAnimatorClipInfoCount(int layerIndex) { }

	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	[FreeFunction(Name = "AnimatorBindings::GetCurrentGraph", HasExplicitThis = True)]
	private void GetCurrentGraph(ref PlayableGraph graph) { }

	[NativeConditional("UNITY_EDITOR")]
	internal string GetCurrentStateName(int layerIndex) { }

	public float GetFloat(string name) { }

	public float GetFloat(int id) { }

	[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = True)]
	private float GetFloatID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::GetFloatString", HasExplicitThis = True)]
	private float GetFloatString(string name) { }

	private Vector3 GetGoalPosition(AvatarIKGoal goal) { }

	private void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret) { }

	private Quaternion GetGoalRotation(AvatarIKGoal goal) { }

	private void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret) { }

	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	private float GetGoalWeightRotation(AvatarIKGoal goal) { }

	private Vector3 GetHintPosition(AvatarIKHint hint) { }

	private void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret) { }

	private float GetHintWeightPosition(AvatarIKHint hint) { }

	public Vector3 GetIKHintPosition(AvatarIKHint hint) { }

	public float GetIKHintPositionWeight(AvatarIKHint hint) { }

	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	public int GetInteger(int id) { }

	public int GetInteger(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = True)]
	private int GetIntegerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::GetIntegerString", HasExplicitThis = True)]
	private int GetIntegerString(string name) { }

	public int GetLayerIndex(string layerName) { }

	public string GetLayerName(int layerIndex) { }

	public float GetLayerWeight(int layerIndex) { }

	public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	[FreeFunction(Name = "AnimatorBindings::GetNextAnimatorClipInfo", HasExplicitThis = True)]
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	public int GetNextAnimatorClipInfoCount(int layerIndex) { }

	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[NativeConditional("UNITY_EDITOR")]
	internal string GetNextStateName(int layerIndex) { }

	public AnimatorControllerParameter GetParameter(int index) { }

	[FreeFunction(Name = "AnimatorBindings::GetParameterInternal", HasExplicitThis = True)]
	private AnimatorControllerParameter GetParameterInternal(int index) { }

	[Obsolete("GetQuaternion is deprecated.")]
	public Quaternion GetQuaternion(int id) { }

	[Obsolete("GetQuaternion is deprecated.")]
	public Quaternion GetQuaternion(string name) { }

	private float GetRecorderStartTime() { }

	private float GetRecorderStopTime() { }

	internal string GetStats() { }

	[Obsolete("GetVector is deprecated.")]
	public Vector3 GetVector(int id) { }

	[Obsolete("GetVector is deprecated.")]
	public Vector3 GetVector(string name) { }

	public bool HasState(int layerIndex, int stateID) { }

	[FreeFunction(Name = "AnimatorBindings::InternalGetBehaviours", HasExplicitThis = True)]
	internal ScriptableObject[] InternalGetBehaviours(Type type) { }

	[FreeFunction(Name = "AnimatorBindings::InternalGetBehavioursByKey", HasExplicitThis = True)]
	internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type) { }

	public void InterruptMatchTarget(bool completeMatch) { }

	public void InterruptMatchTarget() { }

	internal bool IsBoneTransform(Transform transform) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use mask and layers to control subset of transfroms in a skeleton.", True)]
	public bool IsControlled(Transform transform) { }

	private bool IsInIKPass() { }

	public bool IsInTransition(int layerIndex) { }

	public bool IsParameterControlledByCurve(int id) { }

	public bool IsParameterControlledByCurve(string name) { }

	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveID", HasExplicitThis = True)]
	private bool IsParameterControlledByCurveID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveString", HasExplicitThis = True)]
	private bool IsParameterControlledByCurveString(string name) { }

	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) { }

	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) { }

	private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	private void MatchTarget_Injected(ref Vector3 matchPosition, ref Quaternion matchRotation, int targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	[NativeConditional("UNITY_EDITOR")]
	internal void OnCullingModeChanged() { }

	[NativeConditional("UNITY_EDITOR")]
	internal void OnUpdateModeChanged() { }

	public void Play(string stateName, int layer) { }

	public void Play(string stateName) { }

	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = True)]
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	public void Play(int stateNameHash, int layer) { }

	public void Play(int stateNameHash) { }

	public void PlayInFixedTime(int stateNameHash, int layer) { }

	public void PlayInFixedTime(string stateName) { }

	public void PlayInFixedTime(int stateNameHash) { }

	[FreeFunction(Name = "AnimatorBindings::PlayInFixedTime", HasExplicitThis = True)]
	public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) { }

	public void PlayInFixedTime(string stateName, int layer) { }

	public void PlayInFixedTime(string stateName, int layer, float fixedTime) { }

	private void Rebind(bool writeDefaultValues) { }

	public void Rebind() { }

	public void ResetTrigger(string name) { }

	public void ResetTrigger(int id) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerID", HasExplicitThis = True)]
	private void ResetTriggerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = True)]
	private void ResetTriggerString(string name) { }

	internal string ResolveHash(int hash) { }

	internal void set_allowConstantClipSamplingOptimization(bool value) { }

	public void set_animatePhysics(bool value) { }

	public void set_applyRootMotion(bool value) { }

	public void set_avatar(Avatar value) { }

	public void set_bodyPosition(Vector3 value) { }

	[NativeMethod("SetBodyPosition")]
	internal void set_bodyPositionInternal(Vector3 value) { }

	private void set_bodyPositionInternal_Injected(ref Vector3 value) { }

	public void set_bodyRotation(Quaternion value) { }

	[NativeMethod("SetBodyRotation")]
	internal void set_bodyRotationInternal(Quaternion value) { }

	private void set_bodyRotationInternal_Injected(ref Quaternion value) { }

	public void set_cullingMode(AnimatorCullingMode value) { }

	public void set_feetPivotActive(float value) { }

	public void set_fireEvents(bool value) { }

	public void set_keepAnimatorControllerStateOnDisable(bool value) { }

	public void set_keepAnimatorStateOnDisable(bool value) { }

	public void set_layersAffectMassCenter(bool value) { }

	public void set_linearVelocityBlending(bool value) { }

	public void set_logWarnings(bool value) { }

	public void set_playbackTime(float value) { }

	public void set_recorderStartTime(float value) { }

	public void set_recorderStopTime(float value) { }

	[NativeMethod("SetAvatarPosition")]
	public void set_rootPosition(Vector3 value) { }

	private void set_rootPosition_Injected(ref Vector3 value) { }

	[NativeMethod("SetAvatarRotation")]
	public void set_rootRotation(Quaternion value) { }

	private void set_rootRotation_Injected(ref Quaternion value) { }

	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	public void set_speed(float value) { }

	public void set_stabilizeFeet(bool value) { }

	public void set_updateMode(AnimatorUpdateMode value) { }

	public void set_writeDefaultValuesOnDisable(bool value) { }

	public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) { }

	[NativeMethod("SetBoneLocalRotation")]
	private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) { }

	private void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref Quaternion rotation) { }

	public void SetBool(int id, bool value) { }

	public void SetBool(string name, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = True)]
	private void SetBoolID(int id, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = True)]
	private void SetBoolString(string name, bool value) { }

	public void SetFloat(int id, float value) { }

	public void SetFloat(string name, float value) { }

	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = True)]
	private void SetFloatID(int id, float value) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatIDDamp", HasExplicitThis = True)]
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = True)]
	private void SetFloatString(string name, float value) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatStringDamp", HasExplicitThis = True)]
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	private void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition) { }

	private void SetHintWeightPosition(AvatarIKHint hint, float value) { }

	public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	public void SetIKHintPositionWeight(AvatarIKHint hint, float value) { }

	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	public void SetInteger(string name, int value) { }

	public void SetInteger(int id, int value) { }

	[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = True)]
	private void SetIntegerID(int id, int value) { }

	[FreeFunction(Name = "AnimatorBindings::SetIntegerString", HasExplicitThis = True)]
	private void SetIntegerString(string name, int value) { }

	public void SetLayerWeight(int layerIndex, float weight) { }

	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethod("SetLookAtPosition")]
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	public void SetLookAtWeight(float weight) { }

	public void SetLookAtWeight(float weight, float bodyWeight) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	[NativeMethod("SetLookAtWeight")]
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[Obsolete("SetQuaternion is deprecated.")]
	public void SetQuaternion(int id, Quaternion value) { }

	[Obsolete("SetQuaternion is deprecated.")]
	public void SetQuaternion(string name, Quaternion value) { }

	public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) { }

	public void SetTrigger(string name) { }

	public void SetTrigger(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = True)]
	private void SetTriggerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = True)]
	private void SetTriggerString(string name) { }

	[Obsolete("SetVector is deprecated.")]
	public void SetVector(string name, Vector3 value) { }

	[Obsolete("SetVector is deprecated.")]
	public void SetVector(int id, Vector3 value) { }

	public void StartPlayback() { }

	public void StartRecording(int frameCount) { }

	public void StopPlayback() { }

	public void StopRecording() { }

	[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = True)]
	public static int StringToHash(string name) { }

	[NativeMethod("UpdateWithDelta")]
	public void Update(float deltaTime) { }

	[NativeConditional("UNITY_EDITOR")]
	internal void WriteDefaultPose() { }

	[FreeFunction(Name = "AnimatorBindings::WriteDefaultValues", HasExplicitThis = True)]
	public void WriteDefaultValues() { }

}

