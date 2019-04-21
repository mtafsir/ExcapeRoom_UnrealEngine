// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class EscapeRoom_UEEditorTarget : TargetRules
{
	public EscapeRoom_UEEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "EscapeRoom_UE" } );
	}
}
