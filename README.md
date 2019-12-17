This plugin calculates the map grid cell reference for a position.

## Chat Commands

* `/grid` – Display the grid cell of your current position

## Developer API

This plugin is meant to be used by other plugins that want to display the grid reference of something, giving players an intuitive way to understand the rough location of something. 

```csharp
string getGrid(Vector3 position)
```
Returns the grid cell for a Vector3 as string.

### Example

```csharp
string grid = (string)Grid.Call("getGrid", foo.transform.position);
```