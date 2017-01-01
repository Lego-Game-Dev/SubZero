//Copyright 2016-2017 Dark Rising Studios and the Sub Zero Development Community. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class SubZeroTarget : TargetRules
{
	public SubZeroTarget(TargetInfo Target)
	{
		Type = TargetType.Game;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.Add("SubZero");
	}
}
