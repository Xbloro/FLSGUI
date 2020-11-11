# FLSGUI

Small GUI Tool to create FLS on Windows

Since it skips files that it is not allow to access, i suggest to run it as an admin.

run with .net4.x (not needed if compiled as a standalone)

To compile as a standalone with msbuild : Msbuild.exe /t:Publish /p:SelfContained=True /p:Configuration=Release /p:Plateform=x86 /p:PublishDir=C:/Users/wereveruwant
Be sure to run the command on the same directory as the solution file.

I know, the code is not documented and maybe things could have been done better. But it's pretty straight forward.
It works out the box and it's pretty fast.

I'll fixe it when i have time.

Feel free to change what ever u want as long as it improve the tool.

cheers
