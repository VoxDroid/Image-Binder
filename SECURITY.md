# Security Policy

## Supported Versions

The following versions of **Image Binder** are currently supported with security updates:

| Version | Supported          |
|---------|--------------------|
| Latest  | ✅                 |
| Older   | ❌ (Upgrade to latest) |

We recommend always using the latest release to ensure you have the most recent security fixes and improvements.

## Reporting a Vulnerability

If you discover a security vulnerability in Image Binder, we appreciate your help in disclosing it responsibly. Please follow these steps:

1. **Do Not Disclose Publicly**: Avoid sharing details of the vulnerability in public forums, such as GitHub issues, social media, or other platforms, until it has been addressed.
2. **Contact the Maintainer Privately**:
   - Email the maintainer at a secure email address (please check the [repository](https://github.com/VoxDroid/Image-Binder) or [Ko-fi page](https://ko-fi.com/O4O6LO7Q1) for contact details).
   - Include a detailed description of the vulnerability, steps to reproduce, and potential impact.
3. **Response Time**:
   - You can expect an initial response within 48 hours.
   - We will work with you to validate and address the issue promptly.
4. **Disclosure**:
   - Once the vulnerability is fixed, we will coordinate with you on public disclosure, if appropriate.
   - Credit will be given for your discovery in release notes, unless you prefer anonymity.

## Security Best Practices

To keep your use of Image Binder secure:

- **Update Regularly**: Always use the latest version from the [Releases page](https://github.com/VoxDroid/Image-Binder/releases).
- **Verify Downloads**: Download installers only from the official GitHub repository to avoid tampered files.
- **File Handling**: Be cautious when processing images from untrusted sources, as malformed files could exploit vulnerabilities in image processing libraries.
- **Permissions**: Run Image Binder with standard user privileges, as it does not require administrative access for normal operation.

## Known Dependencies

Image Binder relies on the following third-party libraries, which may have their own security policies:

- **PdfSharp**: Used for PDF creation.
- **ImageMagick**: Used for image processing.
- **iText**: Used for PDF metadata handling.
- **Guna.UI2**: Used for the user interface.

Check the respective project pages for their security advisories and ensure you’re using the versions bundled with the latest Image Binder release.

Thank you for helping keep Image Binder secure!