namespace UnityEngine;

[NativeHeader("Modules/Animation/Avatar.h")]
[UsedByNativeCode]
public class Avatar : object
{

	public HumanDescription humanDescription
	{
		 get { } //Length: 87
	}

	public bool isHuman
	{
		[NativeMethod("IsHuman")]
		 get { } //Length: 51
	}

	public bool isValid
	{
		[NativeMethod("IsValid")]
		 get { } //Length: 51
	}

	private Avatar() { }

	public HumanDescription get_humanDescription() { }

	private void get_humanDescription_Injected(out HumanDescription ret) { }

	[NativeMethod("IsHuman")]
	public bool get_isHuman() { }

	[NativeMethod("IsValid")]
	public bool get_isValid() { }

	internal float GetAxisLength(int humanId) { }

	internal Vector3 GetLimitSign(int humanId) { }

	internal Quaternion GetPostRotation(int humanId) { }

	internal Quaternion GetPreRotation(int humanId) { }

	internal Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q) { }

	internal Quaternion GetZYRoll(int humanId, Vector3 uvw) { }

	[NativeMethod("GetAxisLength")]
	internal float Internal_GetAxisLength(int humanId) { }

	[NativeMethod("GetLimitSign")]
	internal Vector3 Internal_GetLimitSign(int humanId) { }

	private void Internal_GetLimitSign_Injected(int humanId, out Vector3 ret) { }

	[NativeMethod("GetPostRotation")]
	internal Quaternion Internal_GetPostRotation(int humanId) { }

	private void Internal_GetPostRotation_Injected(int humanId, out Quaternion ret) { }

	[NativeMethod("GetPreRotation")]
	internal Quaternion Internal_GetPreRotation(int humanId) { }

	private void Internal_GetPreRotation_Injected(int humanId, out Quaternion ret) { }

	[NativeMethod("GetZYPostQ")]
	internal Quaternion Internal_GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q) { }

	private void Internal_GetZYPostQ_Injected(int humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion ret) { }

	[NativeMethod("GetZYRoll")]
	internal Quaternion Internal_GetZYRoll(int humanId, Vector3 uvw) { }

	private void Internal_GetZYRoll_Injected(int humanId, ref Vector3 uvw, out Quaternion ret) { }

	internal void SetMuscleMinMax(int muscleId, float min, float max) { }

	internal void SetParameter(int parameterId, float value) { }

}

