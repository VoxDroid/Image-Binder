# Contributing to Image Binder

Thank you for your interest in contributing to **Image Binder**! We value contributions from the community, whether they are bug reports, feature requests, code improvements, or documentation enhancements. This guide outlines how you can get involved and help improve the project.

## Table of Contents

- [Code of Conduct](#code-of-conduct)
- [How to Contribute](#how-to-contribute)
  - [Reporting Bugs](#reporting-bugs)
  - [Suggesting Features](#suggesting-features)
  - [Submitting Pull Requests](#submitting-pull-requests)
- [Development Setup](#development-setup)
- [Code Style Guidelines](#code-style-guidelines)
- [Testing](#testing)
- [Community](#community)

## Code of Conduct

All contributors are expected to adhere to the [Code of Conduct](CODE_OF_CONDUCT.md). This ensures a respectful and inclusive environment for everyone involved in the project.

## How to Contribute

### Reporting Bugs

If you encounter a bug in Image Binder:

1. **Check Existing Issues**: Search the [Issues page](https://github.com/VoxDroid/Image-Binder/issues) to see if the bug has already been reported.
2. **Create a New Issue**: If the bug is new, open a new issue and provide:
   - A clear title and description of the bug.
   - Steps to reproduce the issue.
   - Expected and actual behavior.
   - Screenshots or logs, if applicable.
   - Your environment (e.g., Windows version, .NET Framework version).
3. **Use the Bug Report Template**: Follow the template provided in the issue creation form for consistency.

### Suggesting Features

We welcome ideas to improve Image Binder! To suggest a feature:

1. **Check Existing Requests**: Review the [Issues page](https://github.com/VoxDroid/Image-Binder/issues) to avoid duplicates.
2. **Submit a Feature Request**: Open a new issue and include:
   - A clear title and detailed description of the feature.
   - The problem it solves or the benefit it provides.
   - Any relevant examples or mockups.
3. **Use the Feature Request Template**: Follow the provided template to structure your suggestion.

### Submitting Pull Requests

To contribute code or documentation:

1. **Fork the Repository**:
   - Fork the [Image Binder repository](https://github.com/VoxDroid/Image-Binder).
   - Clone your fork to your local machine:  
     ```bash
     git clone https://github.com/YOUR_USERNAME/Image-Binder.git
     ```

2. **Create a Branch**:
   - Create a new branch for your changes:  
     ```bash
     git checkout -b feature/your-feature-name
     ```
   - Use descriptive branch names (e.g., `fix/bug-description`, `feature/new-option`).

3. **Make Changes**:
   - Implement your changes in the codebase or documentation.
   - Follow the [Code Style Guidelines](#code-style-guidelines) below.
   - Update or add tests if applicable.

4. **Commit Changes**:
   - Write clear, concise commit messages:  
     ```bash
     git commit -m "Add feature: description of changes"
     ```
   - Reference related issues (e.g., `Fixes #123`).

5. **Push and Create a Pull Request**:
   - Push your branch to your fork:  
     ```bash
     git push origin feature/your-feature-name
     ```
   - Open a pull request (PR) against the `main` branch of the original repository.
   - Use the PR template and provide:
     - A description of the changes.
     - The issue number(s) addressed (if any).
     - Any additional context or screenshots.

6. **Code Review**:
   - Respond to feedback from maintainers.
   - Make requested changes and update your PR as needed.
   - Your PR will be merged once approved.

## Development Setup

To set up a development environment for Image Binder:

1. **Prerequisites**:
   - Windows 10 or later.
   - .NET Framework 4.7.2 or higher.
   - Visual Studio 2022 (Community, Professional, or Enterprise) with the .NET desktop development workload.
   - Git installed for version control.

2. **Clone the Repository**:
   ```bash
   git clone https://github.com/VoxDroid/Image-Binder.git
   cd Image-Binder
   ```

3. **Install Dependencies**:
   - Open the solution file (`ImageBinder.sln`) in Visual Studio.
   - Restore NuGet packages (e.g., PdfSharp, ImageMagick, iText, Guna.UI2) via Visual Studio or the command line:  
     ```bash
     dotnet restore
     ```

4. **Build the Project**:
   - Build the solution in Visual Studio (Ctrl+Shift+B) or via the command line:  
     ```bash
     dotnet build
     ```

5. **Run the Application**:
   - Set the startup project to `Binder` and run it in Visual Studio (F5).
   - Test your changes locally.

## Code Style Guidelines

To maintain consistency in the codebase:

- **Language**: Use C# with .NET Framework conventions.
- **Naming**:
  - Use `PascalCase` for classes, methods, and properties (e.g., `ImageBinder`, `ProcessImages`).
  - Use `camelCase` for local variables and parameters (e.g., `imagePath`, `qualityLevel`).
  - Use descriptive names (e.g., `ConvertPngToJpeg` instead of `ConvertImage`).
- **Formatting**:
  - Follow the default Visual Studio C# formatting settings.
  - Use 4-space indentation.
  - Place opening braces on a new line.
- **Comments**:
  - Add XML documentation for public methods and classes.
  - Use inline comments sparingly for complex logic.
- **Error Handling**:
  - Use try-catch blocks for file operations and external library calls.
  - Display user-friendly error messages via `MessageBox`.
- **UI Components**:
  - Use Guna.UI2 controls consistently for the interface.
  - Ensure tooltips and settings align with the existing UX.

## Testing

Before submitting a pull request:

- **Manual Testing**:
  - Test your changes with various image formats (JPG, PNG) and folder structures.
  - Verify compression settings, metadata, and PDF output.
  - Check for UI responsiveness and error handling.
- **Unit Tests** (if applicable):
  - Add or update unit tests in the test project (if created).
  - Run tests via Visual Studio or:  
    ```bash
    dotnet test
    ```
- **Edge Cases**:
  - Test with invalid files, empty folders, and large image sets.
  - Ensure cancellation and cleanup work as expected.

## Community

Join the Image Binder community:

- **GitHub Discussions**: Share ideas or ask questions in the [Discussions](https://github.com/VoxDroid/Image-Binder/discussions) section.
- **Issues**: Report bugs or suggest features on the [Issues page](https://github.com/VoxDroid/Image-Binder/issues).
- **Ko-fi**: Support the project via [Ko-fi](https://ko-fi.com/O4O6LO7Q1).

Thank you for contributing to Image Binder! Your efforts help make this tool better for everyone.