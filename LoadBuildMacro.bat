@REM -----------------------------------------------------------------------
@echo Now using my code to load the Doskey Build Macro

doskey /macrofile=buildlogoutput\BuildMacro.doskey

@echo
@echo Syntax of Build Command: build buildmgr.proj /t:[targetName] /p:[propertyName]=[value];[propertyName]=[value]
@echo Target Options:	
@echo					UnityTest(default), 
@echo					FxCopAndUnitTest, (no longer implemented)
@echo					CopyScriptsToUnity, 
@echo					Test, 
@echo					Clean, 
@echo					Build, 
@echo					Rebuild
@echo
@echo Property Options: SolutionName=CodeEnv.Master(default), 
@echo                               =Trials.ToUnity (no longer implemented)
@echo                               =POC.ToUnity	(no longer implemented)
@echo
@echo                        Config=Debug(default),
@echo                              =Release,
@echo                              =Debug+Release


@REM -----------------------------------------------------------------------

