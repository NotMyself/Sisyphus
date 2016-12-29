# Sisyphus
Keeps rolling that rock uphill on schedule.

![Sisyphus](/docs/images/sisyphus.jpg?raw=true "Sisyphus")

### Getting Started

1. Clone the repository: `git clone https://github.com/NotMyself/Sisyphus.git`.
2. Change directory into the cloned repository `cd Sisyphus`.
3. Run script to register uri: `script/register_uri.ps1`.
4. Open the `Sisyphus.sln` in Visual Studio.
5. Open the Sql Server Object Explorer View, View > Sql Server Object Explorer.
6. Under the `(localdb)\MSSQLLocalDB` node, right click Databases and select `Add New Database`.
7. Set Database Name to `Sisyphus` and click `OK`.
8. Hit `F5` to start the service as a console application.
9. You should now be able to browse to [http://localhost:8080](http://localhost:80800) to see the Hangfire Dashboard.

### Creating a New Job Project

1. Open the `Sisyphus.sln` solution.
2. Right click on the `Jobs` solution folder and select Add > New Project
3. Select `Class Library` from the `Visual C#` section.
4. Name your library `Sisyphus.Jobs.*JobName*` where JobName is the name of a single job or collection of jobs.
5. Set the Location to the `src` folder located at the root of the repository.
    ![Add New Project](/docs/images/add_new_project.PNG?raw=true "Add New Project")
6. Right click your new project and select Add > Existing Item.
7. Navigate to the `src` folder and select the `SolutionInfo.cs` file.
8. From the `Add` button drop down menu, select `Add As Link`.
    ![Add As Link](/docs/images/add_solution_info.PNG?raw=true "Add As Link")
9. Drag the linked `SolutionInfo.cs` into the `Properties` folder.
10. Open the `AssemblyInfo.cs` file in the Properties folder and remove all attrubutes except these:
    - AssemblyTitle
    - AssemblyDescription
    - Guid
11. Right click the Solution and select Manage Nuget Packages for Solution.
12. You may be prompted for credentails for the Hanfire nuget feed, they can be found in [nuget.config](nuget.config).
13. Add NuGet references to the following pacakges to your project using the installed tab of the Nuget Manager:
    - Autofac
    - Hangfire.Pro
    - Hangfire.Autofac
14. Right click the new project and select Properties.
15. Select the Build tab and modify the Output Directory for both Debug and Release as follows:
    - Debug = ..\Sisyphus.Service\bin\Debug\
    - Release = ..\Sisyphus.Service\bin\Release\ 
16. Right click the Solution and select `Project Dependecies`.
17. For the project `Sisyphus.Service` add a check next to your new project.
    ![Add Project Dependeices](/docs/images/add_project_dependecies.PNG?raw=true "Add Project Dependecies")
18. Build the Solution.
19. Ensure your new project's built assembly is located in the `bin` directory for the Sisyphus.Service project.
