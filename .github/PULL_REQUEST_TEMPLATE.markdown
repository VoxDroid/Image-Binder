# Pull Request

Thank you for contributing to **Image Binder**! Please complete this template to help us review your changes efficiently. Ensure your pull request adheres to the [Contributing Guidelines](https://github.com/VoxDroid/Image-Binder/blob/master/CONTRIBUTING.md) and the [Code of Conduct](https://github.com/VoxDroid/Image-Binder/blob/master/CODE_OF_CONDUCT.md).

## Description

Provide a clear and concise description of the changes in this pull request. Explain:
- What problem it solves or what feature it adds.
- The approach you took to implement the changes.
- Any relevant technical details or trade-offs.

## Related Issues

List any GitHub issues this pull request addresses. Use the format `Fixes #123` or `Closes #123` to automatically link and close issues upon merging.

- Fixes # [issue number]
- Related to # [issue number]

## Type of Change

Check the appropriate box(es) to indicate the type of change:

- [ ] Bug fix (non-breaking change that resolves an issue)
- [ ] New feature (non-breaking change that adds functionality)
- [ ] Breaking change (fix or feature that would cause existing functionality to change)
- [ ] Documentation update (changes to README, CONTRIBUTING, or other docs)
- [ ] Code style or refactoring (no functional changes)
- [ ] Other (please describe):

## How Has This Been Tested?

Describe the testing you performed to verify your changes. Include:

- Manual tests (e.g., tested with specific image formats, folder structures, or UI interactions).
- Automated tests (if applicable, e.g., unit tests added or updated).
- Edge cases considered (e.g., invalid files, large image sets, cancellation).
- Environment tested (e.g., Windows 10, .NET Framework 4.7.2).

**Example:**
- Tested binding 100 PNG images with lossless mode enabled.
- Verified metadata fields are correctly embedded in the output PDF.
- Ran `dotnet test` with no failures.
- Tested on Windows 11 with .NET Framework 4.8.

## Screenshots (if applicable)

If your changes affect the UI or output, attach screenshots to demonstrate the results. For example, show the updated interface, error messages, or PDF output.

## Checklist

Please confirm the following before submitting your pull request:

- [ ] My code follows the [Code Style Guidelines](https://github.com/VoxDroid/Image-Binder/blob/master/CONTRIBUTING.md#code-style-guidelines) (e.g., PascalCase for methods, 4-space indentation).
- [ ] I have added or updated tests where necessary.
- [ ] I have updated the documentation (e.g., README, comments) if my changes impact usage or setup.
- [ ] My changes do not introduce new warnings or errors during the build.
- [ ] I have tested my changes thoroughly and verified they work as expected.
- [ ] My pull request targets the `main` branch.
- [ ] I have reviewed my changes to ensure they are focused and do not include unrelated modifications.

## Additional Context

Provide any additional information that might help reviewers understand your changes. For example:
- Why you chose a specific library or approach.
- Any limitations or known issues with your implementation.
- Future improvements you plan to address.

---

**Note**: Maintainers may request changes or clarification during the review process. Please respond promptly to feedback to ensure a smooth merge.

Thank you for your contribution to Image Binder!