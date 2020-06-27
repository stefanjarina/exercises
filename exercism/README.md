# Exercism Exercises

Completed exercises from [https://exercism.io](https://exercism.io)

## Running tests

### Bash

```bash
bats filename_test.sh
```

### C#/F#

```bash
dotnet test
```

### Elixir

```bash
mix test
```

### Go

```bash
go test                              # no benchmarks
go test -v --bench . --benchmem      # with benchmarks
```

### Python

- Testing tool

```bash
pip3 install pytest pytest-cache
```

- Run tests

```bash
pytest filename_test.py              # just run tests
pytest -x filename_test.py           # stops after first failure
pytest --ff filename_test.py         # failed tests first
pytest -x --ff filename_test.py      # recommended way to run test suite
```

### Swift

```bash
swift test                        # runs tests
swift package generate-xcodeproj  # creates an Xcode project
```

## list.ps1

cli interface to explore which exercises are done. <br />
Works in Windows (PowerShell Windows 5+) and Linux/MacOSX (Powershell Core 6+).
cli is case insensitive.

* check if exercise is done/started for particular language (no output if exercise not started)

```powershell
./list.ps1 leap ruby
./list.ps1 -Name leap -Lang ruby
```

* list all languages for each specific exercise is either done or started

```powershell
./list.ps1 leap
./list.ps1 -Name leap
```

* list done/started exercises for particular language

```powershell
./list.ps1 "" ruby
./list.ps1 -Lang ruby
```

* list ALL done/started exercises for ALL languages

```powershell
./list.ps1
./list.ps1 "" ""
./list.ps1 -Name "" -Lang ""
```
