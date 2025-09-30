# AmazonStoreFront.net

A multi-project .NET example solution demonstrating a small e-commerce store. The solution contains a console app, a class library for e-commerce domain logic, and a .NET MAUI front-end application.

This README documents repository structure, how to build and run the projects, development notes, and recommended next steps.

## Repository structure

- `ConsoleApp1/` - A small .NET console application. Often used for quick utilities or local demos.
- `Library.eCommerce/` - Class library holding domain models and business logic for the e-commerce store.
- `Maui.eCommerce/` - .NET MAUI application intended as the cross-platform storefront UI.
- `ConsoleApp1.sln` - Top-level solution file referencing the projects in this repo.

## Requirements

- .NET 8 SDK (or later). Verify with `dotnet --version`.
- For MAUI development: Visual Studio 2022/2023 (Windows) or Visual Studio for Mac with the .NET MAUI workload installed and Android/iOS toolchains configured.

## Quick start — build and run

From the repository root open a PowerShell terminal and run:

```powershell
dotnet restore
dotnet build -c Debug
```

Run the console app

```powershell
cd ConsoleApp1
dotnet run
```

Open the MAUI app

The MAUI project is best opened and run from Visual Studio so you can pick a target (Windows, Android emulator, etc.):

1. Open `Maui.eCommerce.sln` in Visual Studio.
2. Select a startup project (usually `Maui.eCommerce`) and target platform.
3. Run (F5) or Deploy.

## Development notes

- This repository appears to be a work-in-progress. Inspect `Library.eCommerce` for domain models and services to understand the data flow.
- The MAUI project includes generated files under `obj/` and a default `AppShell` and `MainPage` that you can customize.

## Contributing

1. Fork the repository on GitHub.
2. Create a feature branch: `git checkout -b feature/your-feature`.
3. Commit changes with clear messages.
4. Push and open a Pull Request.

If you'd like me to create issues, add a CI workflow, or scaffold tests, tell me what flavor of CI you prefer (GitHub Actions, Azure Pipelines, etc.) and I'll add a minimal pipeline.

## Pushing changes to the remote

This repository's remote is expected to be: `https://github.com/JudahA72/AmazonStoreFront.net.git`.

To add/set that remote locally and push your branch:

```powershell
cd <repository-root>
# Add or set the origin remote
git remote add origin https://github.com/JudahA72/AmazonStoreFront.net.git
# or if origin already exists and you want to update its URL:
git remote set-url origin https://github.com/JudahA72/AmazonStoreFront.net.git

# Push current branch to origin (you may be prompted for credentials or use a PAT)
git push -u origin HEAD
```

If you prefer SSH and have keys configured, use the SSH remote instead.

## Troubleshooting

- If `dotnet build` fails, check that the .NET SDK version is compatible (8.0+).
- If MAUI targets are missing in Visual Studio, install the .NET MAUI workload via the Visual Studio Installer.
- If `git push` fails due to authentication, create and use a Personal Access Token (PAT) or configure SSH keys.

