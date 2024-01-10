using UnrealBuildTool;

public class ProyectoUnrealGrupo3ClientTarget : TargetRules
{
	public ProyectoUnrealGrupo3ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ProyectoUnrealGrupo3");
	}
}
