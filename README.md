# SurfaceManualRotation
![React](https://img.shields.io/badge/Windows-blue) 
![React](https://img.shields.io/badge/CSharp-purple) 
![version](https://img.shields.io/github/v/tag/kosmicteal/SurfaceManualRotation?label=version&color=blue)

## About

Back in Windows 10, you could manually toggle Tablet mode in compatible PCs. This was removed on Windows 11, opting for a check whenever a Keyboard was recognized on the OS. For some reason on my PC, it doesn't automatically swap when I don't have my Keyboard connected so, I did this small app to do the change manually.

In order to fully allow the app to make the Registry change, some things must be done beforehand:

* On this app:
  * Save the app in a safe place and do the next changes on its Properties (Secondary click - Properties):
    * Unlock (due to it being downloaded from the Internet).
    * Compatibility - Run this program as an administrator. 
* On the same folder than this app:
  * Create a shortcut to `C:\Windows\System32\schtasks.exe /run /tn "SurfaceManualRotation"` and add it to your task bar.
* Create a task to bypass the UAC screen:
  * Search for "task" on your PC and choose the Task Scheduler
  * Create a new task (not the basic option) with the next properties:
    * General (add a name and description you'll recognize):
      * Execute with the higher privileges
      * Set up for Windows Vista - Server 2008
    * Actions
      * Add an action that "Starts an application"
        * Locate your application and copy its address
        * Add the argument `/c start "" (Address of your saved app)`
    * Settings (next-to-last tab)
      * Allow the task to be run on demand 

## Disclaimer

All product and company names are trademarks or registered trademarks of their respective copyright holders. No copyright has been infringed with this application and I hold no responsibility if there's any change on future updates that disable the functionality of this app. I do not take any liability for any of the forks or damage done from this software; no reverse engineering, disassembly or decompilation was done.

## For more information

* [KosmicTeal's website](https://kosmicteal.github.io/)
