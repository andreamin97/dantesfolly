using UnrealBuildTool;

public class Dantes_FollyTarget : TargetRules
{
	public Dantes_FollyTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Dantes_Folly");
	}
}
