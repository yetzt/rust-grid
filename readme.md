This is a plugin or the [uMod plugin system](https://umod.org/) for the game [Rust](https://rust.facepunch.com/).

This plugin calculates the map grid cell reference for a position

## Chat Commands

* `/grid` – Displays the grid cell of your current position

## Developer API

This plugin is meant to be used by other plugins that want to display the grid reference of something, giving players an intuitive way to understand the rough location of something. 

**`string getGrid(Vector3 position)`**

returns the grid cell for a Vector3 as string

### Example

```csharp
string grid = (string)Grid.Call("getGrid", foo.transform.position);
```

## License

This plugin is free and unemcumbered software released into the public domain. For more information, see the included [UNLICENSE](./UNLICENSE) file.
