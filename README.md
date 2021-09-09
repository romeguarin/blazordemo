.NET MAUI Blazor sample
Pre-requisites:  
- Install .NET 6 Preview and .NET MAUI workloads (including Blazor Web)  
  * ensure dotnet CLI is also installed as we will use that to install tools for and build maui apps  

### Projects:  
1. dotnetmauiblazor and dotnetmauiblazor.WinUI  
   - created using command: `dotnet new mauiblazor -n dotnetmauiblazor`  
2. dotnetblazorwasm  
   - created using command: `dotnet new blazorwasm -n dotnetblazorwasn`
3. Components  
   - created using command: `dotnet new razorclasslib -n Components`  
4. DataServices
   - created using command: `dotnet new classlib -n DataServices`  

Note: for 2 - 4 projects, they were created while inside the solution folder created after executing the command on 1.  
      use the command: `dotnet sln add **/*.csproj` to add them all at once or
      add them one by one after each `dotnet new...` command  


### To build the projects: 
1. dotnetmauilblazor  
  - ensure you have an Android Emulator on standby,
    then go to the project folder and run the following command:
    `dotnet build -t:Run -f net6.0-android`
2. dotnetblazorwasm
  - go to the project folder and run the command: `dotnet watch run`