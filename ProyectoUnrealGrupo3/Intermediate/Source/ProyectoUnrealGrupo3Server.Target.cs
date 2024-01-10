using UnrealBuildTool;

public class ProyectoUnrealGrupo3ServerTarget : TargetRules
{
	public ProyectoUnrealGrupo3ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ProyectoUnrealGrupo3");
	}
}
