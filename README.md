# HexArch

Project shows how to use two different data stores using Hexagonal Architecture.

There are two different data access layers:

- `InMemoryDataAccess` to use in development
- `EntityFrameworkDataAccess` for every other environment

## How to use different environment?

To test how application behaves in different environment change the `ASPNETCORE_ENVIRONMENT` property value in `HexArch.Web/Properties/launchSettings.json` to e.g.: `Production`.

# TODO

- [ ] Add automatic tests
  - [ ] Run tests both in `Development` and `Production` environments
