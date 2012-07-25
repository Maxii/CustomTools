@echo off

:: Copies .dll and .pdb to Unity, convert .pdb to .mdb, then cleanup unneeded .pdb
:: The passed parameter %1 is $(TargetPath).

:: Copy target.dll to Unity project's CodeLibrary
xcopy "%1" "%UNITY_ENV_DIR%\UnityEntry\Assets\CodeLibrary\" /y /r

:: Copy the target.pdb debug file to Unity project's CodeLibrary. 
:: %~dpn1 extracts everything except the extension.
xcopy "%~dpn1.pdb" "%UNITY_ENV_DIR%\UnityEntry\Assets\CodeLibrary\" /y /r

:: Executes pdb2mdb.exe on the target.dll now located in the Unity project's CodeLibrary. 
:: %~nx1 extracts the target's filename and extension.
"C:\Program Files\Unity\Editor\Data\Mono\lib\mono\2.0\pdb2mdb.exe" "%UNITY_ENV_DIR%\UnityEntry\Assets\CodeLibrary\%~nx1"

:: Delete the .pdb file in the Unity project's CodeLibrary that was just used to generate the .mdb
:: %~n1 extracts the target's filename.
erase "%UNITY_ENV_DIR%\UnityEntry\Assets\CodeLibrary\%~n1.pdb"

:: Next thing to try out - make a seperate .bat file for Release and Debug for
:: copying, but keep the branching logic in the post build events. 
::
:: After that, look into the MSBuild template approach and incorporate all build
:: related work into it.


:: HISTORY
:: This works as a command line in the post build event, but not in a batch file
:: because these environment macros have no meaning inside a batch file
:: To make them work, they must be interpreted inside the build event, then
:: passed as parameters
::start copy /y "$(TargetPath)" "$(SolutionDir)..\Assets\GameCodeLibrary\"


:: PARAMETER PASSING syntax %1=first parameter, extraction: %~d1=drive, %~p1=path, %~n1=filename, %~x1=extension
:: 
:: These work with parameters = $(TargetDir) $(SolutionDir), best for all assemblies
:: Copy assembly output files to Unity Code Library
::xcopy "%1*.dll" "%2..\Assets\GameCodeLibrary\" /y /r

:: Copy debug output files to Unity Code Library
::xcopy "%1*.mdb" "%2..\Assets\GameCodeLibrary\" /y /r


:: This also works but with "$(TargetDir)" "$(SolutionDir)"
::xcopy %1*.dll %2..\Assets\GameCodeLibrary\ /y /r

:: This works with $(TargetPath) $(SolutionDir), copies THE target output assembly file
::copy "%1" "%2..\Assets\GameCodeLibrary\" /y /r

::If you want to only do this on Release Build add:
::if $(ConfigurationName) == Release xcopy ...


:: XCOPY SYNTAX
:: /y - do not prompt when about to overwrite a file 
:: /r - copy readonly files too

:: Means if >= 1. xcopy's 0 errorlevel indicates success, 1-5 indicate various errors
::if errorlevel 1 pause

:: Copy target.dll to Unity GameCodeLibrary
:: $(TargetPath), %~dp1 yields the path, then ..\ moves up 4 levels to SolnDir
::xcopy "%1" "%~dp1..\..\..\..\Assets\GameCodeLibrary\" /y /r

:: Copy the target.pdb debug file to Unity GameCodeLibrary
::xcopy "%~dpn1.pdb" "%~dp1..\..\..\..\Assets\GameCodeLibrary\" /y /r

:: Executes pdb2mdb.exe on the passed parameter "UnityGameCodeLibrary\target.dll"
::"C:\Program Files\Unity\Editor\Data\Mono\lib\mono\2.0\pdb2mdb.exe" "%~dp1..\..\..\..\Assets\GameCodeLibrary\%~nx1"

:: Delete the .pdb file in the GameCodeLibrary that was just used to generate the .mdb
::erase "%~dp1..\..\..\..\Assets\GameCodeLibrary\%~n1.pdb"


