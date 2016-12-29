# Sisyphus
Keeps rolling that rock uphill on schedule.

![Sisyphus](/docs/sisyphus.jpg?raw=true "Sisyphus")

### Getting Started

1. Clone the repository: `git clone https://github.com/NotMyself/Sisyphus.git`.
2. Change directory into the cloned repository `cd Sisyphus`.
3. Run script to register uri: `script/register_uri.ps1`.
4. Open the `Sisyphus.sln` in Visual Studio.
5. Open the Sql Server Object Explorer View, View > Sql Server Object Explorer.
6. Under the `(localdb)\MSSQLLocalDB` node, right click Databases and select `Add New Database`.
7. Set Database Name to `Sisyphus` and click `OK`.
8. Hit `F5` to start the service as a console application.
9. You should now be able to browse to [http://localhost:80800](http://localhost:80800) to see the Hangfire Dashboard.
