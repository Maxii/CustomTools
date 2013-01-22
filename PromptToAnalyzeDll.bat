@echo on

set /P assy=Enter Full Path to Assembly: %=%
:: assy is the variable that is assigned the value supplied after the prompt.

:: Usage - simply run this batch file and at the prompt paste the path to the Assembly and press enter.
:: Opens a command line window and shows the analysis, then prompts the user before closing.

"C:\Users\Jim\GameDev\CustomTools\CustomTools.Reflector\bin\Debug\CustomTools.Reflector.exe" %assy%

Pause

