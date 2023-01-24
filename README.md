## Requirements
* dotnet >= 6.0

## Build and run
1. Run command `dotnet run`.
2. Open browser link `http://localhost:5000/swagger` . If port 5000 was already occupied before, see console for what port was assigned to this dotnet app.

## Reproduction
1. [Start application](#build-and-run).
2. Expand any endpoint, they should open instantly.
3. Uncomment (remove two slashes) file Program.cs line 11: `o.UseOneOfForPolymorphism();`. Save changes.
4. [Restart the application](#build-and-run) and refresh the page.
5. Expand any endpoint, they now have performance degradation.
6. To make it even worse: add new properties (complex and cyclic types will do better) to `Animal` class, or duplicate more Lions and Mice classes. Restart the application to apply changes.